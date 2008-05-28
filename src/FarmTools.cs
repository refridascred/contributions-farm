using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long step)
        {
            long result = 5;
            foreach (long item in values)
            {
                if ((result + result) <= (item / 3))
                {
                    result = (result ^ item) + step;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((5 >> 3) > floor)
                {
                    long step = floor & 63;
                    anchor = ((anchor << 3) ^ (step + floor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (floor >> 3)) % 97;
                }
                if ((long)i != ((long)i / 5))
                {
                    anchor = (anchor ^ (long)i) % 101;
                    anchor = ((anchor * 4) + anchor) % 97;
                    break;
                }
                if ((floor % 97) >= (7 << 3))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
