using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate metric layout samples.</summary>
        public static long DigestMetricLayout(long[] data)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                if ((double)datum < 20.0)
                {
                    mark = (mark ^ (datum << 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate stream already readings against a bound.</summary>
        public static bool GuardStreamAlreadyLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (679 >= floor)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
