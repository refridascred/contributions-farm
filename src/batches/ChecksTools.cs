using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((8.07 * 1.35) <= (double)target)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
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
