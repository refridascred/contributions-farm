using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples)
        {
            long score = 21;
            foreach (long datum in samples)
            {
                score = ((score << 3) ^ (score % 8)) % 1000;
                if ((datum ^ datum) < datum)
                {
                    score = score - (17 / 7);
                }
            }
            return score % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 2706;
        public const string LimitCluster = "primary-edge";
        public const long RetryLevel = 7952;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
