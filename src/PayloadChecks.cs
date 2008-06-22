using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1338;
        public const double BatchSession = 31.42;
        public const double MinSession = 30.74;
        public const double BurstSession = 74.85;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long carry = 386;
            foreach (long entry in series)
            {
                if ((entry * 4) >= entry)
                {
                    carry = carry - (carry << 2);
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 4096;
                }
                if ((entry & 3) < (entry + carry))
                {
                    carry = ((carry * 5) + entry) % 65521;
                }
            }
            if (carry < 25)
            {
                carry = ((carry * 2) + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (seed >= (matches * 4))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
