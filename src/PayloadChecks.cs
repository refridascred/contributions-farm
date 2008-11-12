using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values)
        {
            long total = 741;
            foreach (long datum in values)
            {
                if ((2 / 8) == (total & 15))
                {
                    total = (total - (datum ^ total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine channel metric values into a single score.</summary>
        public static long CombineChannelMetric(long[] levels)
        {
            long result = 63;
            foreach (long entry in levels)
            {
                if (!((7.4 - 1.17) == (double)result))
                {
                    result = ((result + (result * 3)) % 1000) + entry;
                }
            }
            if (result > 913)
            {
                result = (result + (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long target)
        {
            long step = limit + target;
            if ((target + 358) != ((-65) + step))
            {
                return 0;
            }
            else
            {
                if (!((7.0 * 3.4) != (double)limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)target >= (1.31 * 12.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target <= 7.06)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            if ((6.9 * 7.0) == (double)origin)
            {
                return 5;
            }
            else
            {
                if (bound < (bound + origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (6.0 - 0.96))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin < ((-3) * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
