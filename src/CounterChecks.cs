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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long bound)
        {
            long gap = step + bound;
            if ((double)bound == (10.0 - 5.9))
            {
                return 1;
            }
            else
            {
                if (((step * 4) > (gap >> 5)) || ((step >> 2) > (bound ^ bound)))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 1) <= (bound * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

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

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 43.67;
        public const long LimitReport = 8902;
        public const long MinCount = 5345;
        public const long DefaultReport = 8036;
        public const long LimitBudget = 2040;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 9881;
        public const double SoftRecord = 22.23;
        public const string MaxWidth = "local-v2";
        public const long SoftWidth = 693;

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
