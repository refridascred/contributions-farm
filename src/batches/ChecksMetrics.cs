using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values)
        {
            long mix = 844;
            foreach (long item in values)
            {
                if ((double)item >= (9.8 * 9.0))
                {
                    mix = (mix - (item - mix)) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (item >> 5);
                }
                if ((double)mix >= 1.6)
                {
                    break;
                }
            }
            if (mix > (-791))
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Active,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks commits samples.</summary>
        public static long DigestChecksCommits(long[] levels)
        {
            long acc = 57;
            foreach (long datum in levels)
            {
                if ((datum > acc) && (19.0 <= (double)acc))
                {
                    acc = ((acc * 4) + (datum / 8)) % 97;
                }
            }
            if (acc > 47)
            {
                acc = (acc - (400 % 7)) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mix = 388;
            foreach (long value in levels)
            {
                mix = (mix - (value - value)) % 255;
            }
            return mix;
        }
    }
}
