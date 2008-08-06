using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count entry token pairs that satisfy a relation.</summary>
        public static long OverlapEntryTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metric cluster samples.</summary>
        public static long ScoreMetricCluster(long[] readings)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                double drift = (16.0 * 6.7) - (5.5 + 1.9);
                if ((drift / 3.0) > drift)
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = anchor ^ entry;
            }
            return anchor % 97;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
