using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6 - item) >= 0)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + sample) > (count % 100))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
