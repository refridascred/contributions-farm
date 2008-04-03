using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                long matches = (seed + seed) - seed;
                if (!((((long)i / 9) > matches) && ((19 + mix) < seed)))
                {
                    matches = (matches ^ seed) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels)
        {
            long carry = 740;
            foreach (long value in levels)
            {
                carry = ((carry << 3) ^ ((-12) + value)) % 101;
                if (((carry * 4) >= (carry - carry)) && (3.7 >= (double)value))
                {
                    carry = (carry << 3) ^ (value + value);
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
            }
            if (carry < 178)
            {
                carry = carry + (carry - carry);
            }
            return carry;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches << 1) > (long)items.Length) || (matches >= (reading % 16)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
