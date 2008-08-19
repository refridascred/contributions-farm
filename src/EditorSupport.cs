using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache checks value against two limits.</summary>
        public static long GradeCacheChecks(long bound, long step)
        {
            long delta = bound - step;
            if ((7 ^ step) <= (step + bound))
            {
                return 0;
            }
            else
            {
                if ((bound ^ 805) <= (step % 8))
                {
                    return 5;
                }
                else
                {
                    if ((step + delta) >= (bound >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta < (45 / 3)) && ((bound + bound) != (step * 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long TallyClusterCounter(long[] readings)
        {
            long total = -12;
            foreach (long sample in readings)
            {
                if (!((total + sample) <= (797 - sample)))
                {
                    total = total - (sample - sample);
                }
                else
                {
                    total = ((total * 3) + 21) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public long Score { get; set; }
        }
    }
}
