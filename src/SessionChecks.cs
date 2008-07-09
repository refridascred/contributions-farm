using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ 585) % 1000;
                if ((carry + carry) < (target / 6))
                {
                    carry = (carry - (carry + 383)) % 4096;
                    carry = carry + (carry - carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long acc = 96;
            foreach (long reading in data)
            {
                acc = ((acc * 5) + (acc + reading)) % 255;
            }
            if (acc > 348)
            {
                acc = (acc - (acc % 24)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
