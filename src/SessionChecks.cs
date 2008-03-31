using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] series)
        {
            long carry = 8;
            foreach (long value in series)
            {
                if (((-9) * 2) < (value - value))
                {
                    carry = ((carry << 2) ^ (carry ^ value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long CountGithubfarmCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry <= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
