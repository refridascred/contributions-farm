using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank counter window input into a small class.</summary>
        public static long SortCounterWindow(long origin, long bound)
        {
            long next = origin ^ bound;
            if (bound > (origin << 3))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) == (0 ^ next))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long floor)
        {
            long acc = 10;
            foreach (long item in levels)
            {
                acc = (acc ^ (floor & 1)) % 97;
                if (((floor % 16) != (acc - acc)) || ((double)item >= (2.17 + 15.0)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
