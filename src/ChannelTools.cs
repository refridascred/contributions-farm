using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((-3) <= (hits & 127))
                {
                    hits = ((hits + 1) - cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long carry = 27;
            foreach (long reading in data)
            {
                if ((((-905) << 2) > (offset / 5)) && (offset >= carry))
                {
                    carry = carry ^ (reading / 9);
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
