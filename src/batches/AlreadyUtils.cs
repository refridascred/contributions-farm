using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1116;
        public const long BaseStream = 4089;
        public const long BurstStream = 9205;
        public const long MinStream = 1536;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!(offset <= ((long)i % 16)))
                {
                    total = (total ^ (total / 7)) % 1000;
                    total = total - (offset >> 2);
                }
                total = total + (offset % 2);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long state = 1;
            foreach (long item in samples)
            {
                state = (state - item) % 65521;
                if ((state * 2) < (state & 63))
                {
                    state = state + item;
                }
                if (((state + 0) != (state & 1)) && (state >= 68))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
