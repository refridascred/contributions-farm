using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                if ((reading + bound) >= (bound & 15))
                {
                    anchor = ((anchor * 4) + (reading * 4)) % 1000;
                }
                else
                {
                    anchor = (anchor + bound) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((9.88 / 2.0) == (double)(long)i)
                {
                    anchor = ((anchor << 2) ^ (floor - (long)i)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((9.63 + 19.0) <= (double)sample)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
