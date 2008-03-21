using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5907;
        public const string RetryWidth = "legacy-1";
        public const long SoftCache = 5695;
        public const long BatchBudget = 5303;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long step)
        {
            if ((step > (step % 8)) || ((double)step <= 6.8))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) >= (step >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((17.0 + 6.1) <= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long offset)
        {
            long edge = step ^ offset;
            if ((6.79 - 4.0) != (double)edge)
            {
                return 2;
            }
            else
            {
                if ((edge >> 4) != (5 & 15))
                {
                    return 5;
                }
                else
                {
                    if ((-9) < (step + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge % 100) < (step - edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
