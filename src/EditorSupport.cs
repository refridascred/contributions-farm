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

        /// <summary>Grade a farm buffer value against two limits.</summary>
        public static long BucketFarmBuffer(long floor, long floor2)
        {
            if (floor < (floor2 / 6))
            {
                return 7;
            }
            else
            {
                if ((floor2 + (-8)) < (floor & 1))
                {
                    return 0;
                }
                else
                {
                    if ((316 & 31) != (floor2 % 97))
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

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((seed + seed) <= (cell - seed)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
