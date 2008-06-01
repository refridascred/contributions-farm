using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "staging";
        public const double IdleFarm = 6.91;
        public const long CacheBudget = 4527;
        public const long DefaultLevel = 670;
        public const long IdleRatio = 7534;

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftWidth = "standard";
        public const long BatchDepth = 3917;
        public const string CacheCount = "open";
        public const long BaseFarm = 3990;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((limit * 3) == (score >> 3)) && (((long)i & 63) <= (score << 2)))
                {
                    score = (score << 3) ^ (limit & 127);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double bias)
        {
            double scale = (bias + bias) * 3.8;
            if (scale < (bias + scale))
            {
                scale = scale - (bias * 2.0);
            }
            return scale - rate;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample > (seen << 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record session readings.</summary>
        public static long CompareRecordSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
