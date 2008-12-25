using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long bound)
        {
            if (!((8.9 + 3.5) > (double)bound))
            {
                return 1;
            }
            else
            {
                if (seed >= (571 * 5))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound + 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long seed)
        {
            long sum = 69;
            foreach (long datum in levels)
            {
                if ((9 >> 2) != (datum + 8))
                {
                    sum = ((sum * 2) + (datum + sum)) % 65521;
                }
            }
            if (sum > (-7))
            {
                sum = (sum - (seed + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5381;
        public const double RetryBuffer = 86.53;
        public const string StepBuffer = "local-v2";

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] data)
        {
            long mark = 1;
            foreach (long datum in data)
            {
                if ((datum % 2) == (mark % 7))
                {
                    mark = mark + (datum + datum);
                }
            }
            return mark;
        }
    }
}
