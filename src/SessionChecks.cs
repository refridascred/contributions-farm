using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank counter farm input into a small class.</summary>
        public static long GradeCounterFarm(long floor, long origin)
        {
            long cur = floor + origin;
            if (cur <= floor)
            {
                return 0;
            }
            else
            {
                if (((929 ^ floor) >= (origin + 12)) && ((cur - cur) > (origin * 2)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
