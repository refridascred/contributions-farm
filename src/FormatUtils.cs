using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long offset)
        {
            if ((7.0 + 7.0) == (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset * 2) > (-608))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank report queue input into a small class.</summary>
        public static long GradeReportQueue(long step, long target)
        {
            if (!((250 ^ step) == (target + step)))
            {
                return 7;
            }
            else
            {
                if (56 >= (target - step))
                {
                    return 4;
                }
                else
                {
                    if ((9.03 / 2.0) != (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.64 * 2.3) != (double)step)
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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((320 + value) <= 612)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
