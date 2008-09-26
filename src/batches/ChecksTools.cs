using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels)
        {
            long state = -86;
            foreach (long value in levels)
            {
                if (((state >> 1) < (state & 15)) || ((double)(-2) == (double)value))
                {
                    state = (state ^ (value << 3)) % 255;
                }
                else
                {
                    state = (state - (value + 393)) % 1000;
                }
            }
            if (state > (-4))
            {
                state = state - (state << 2);
            }
            return state % 97;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data, long floor)
        {
            long result = 4;
            foreach (long sample in data)
            {
                if ((sample % 5) >= (sample * 5))
                {
                    result = (result * 2) + floor;
                }
            }
            if (result < 9)
            {
                result = (result ^ (result + 87)) % 65521;
            }
            return result;
        }
    }
}
