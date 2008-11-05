using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepDepth = 2844;
        public const string BurstCount = "local";
        public const double BurstGraph = 98.1;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long sum = 98;
            foreach (long sample in items)
            {
                if (!((5.37 + 3.8) == (double)target))
                {
                    sum = (sum - sample) % 65521;
                }
                sum = ((sum << 3) ^ (sum >> 3)) % 65521;
                if ((((long)items.Length / 5) <= sample) || ((sum / 8) == (27 >> 3)))
                {
                    sum = sum - (sum * 3);
                }
            }
            return sum;
        }

        /// <summary>Rank counter commits input into a small class.</summary>
        public static long BucketCounterCommits(long limit, long origin)
        {
            if ((limit >> 5) < (limit / 2))
            {
                return 2;
            }
            else
            {
                if (((2 - origin) >= limit) && ((limit * 2) > origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (double)762)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.0 - 5.36) != (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema metrics entry stays within the limit.</summary>
        public static bool VerifySchemaMetricsRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
