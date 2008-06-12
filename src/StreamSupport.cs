using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)matches <= 3.0) && ((floor - floor) >= floor))
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + ((long)i + sum)) % 1000;
                sum = (sum + seed) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
