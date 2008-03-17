using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Stale,
            Paused,
            Idle,
            New,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Stale,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] series, long target)
        {
            long carry = 7;
            foreach (long item in series)
            {
                if ((double)item > (5.7 - 3.4))
                {
                    carry = ((carry - (53 - carry)) % 101) + target;
                }
                carry = ((carry << 3) ^ (1 - carry)) % 97;
            }
            if (carry < 68)
            {
                carry = (carry * 4) + 66;
            }
            return carry % 1000;
        }
    }
}
