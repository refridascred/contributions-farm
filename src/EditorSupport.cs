using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry + ((long)i + carry)) % 101;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the profile route entries that pass the check.</summary>
        public static long TallyProfileRouteMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + 788) <= (target % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Stale,
            Locked,
        }
    }
}
