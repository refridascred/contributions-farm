using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of cluster editor readings.</summary>
        public static long FoldClusterEditor(long[] values)
        {
            long anchor = 3;
            foreach (long value in values)
            {
                anchor = anchor - (anchor + 527);
                if (6.3 >= (double)(long)values.Length)
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
                else
                {
                    anchor = (anchor + ((long)values.Length - value)) % 97;
                }
                if ((value >> 2) != (value >> 5))
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (!((34 - diff) >= limit))
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (5.17 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor <= (floor << 2)) || (floor < diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((408 + limit) != (floor - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long target)
        {
            long total = 87;
            foreach (long value in values)
            {
                if ((target + 831) >= 921)
                {
                    total = ((total ^ 11) % 255) + value;
                }
                else
                {
                    total = (total * 2) + (target >> 3);
                }
            }
            if (total < (-2))
            {
                total = (total ^ (target << 1)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Derive the next buffer record value from a seed.</summary>
        public static long StepBufferRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                if (!(1.58 <= (double)result))
                {
                    result = (result - (result & 127)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((result >> 3) < (4 + (long)i)) && ((result & 7) == (result >> 5)))
                {
                    result = (result - result) % 1000;
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
