using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheScore = 4169;
        public const double HardFarm = 32.53;
        public const long CacheFarm = 4851;
        public const string RetryFarm = "open-1";

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset + ratio))
            {
                ratio = ratio + (ratio - ratio);
            }
            else
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (weight - weight)) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
