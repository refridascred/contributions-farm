using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many support context samples are out of range.</summary>
        public static long TallySupportContextGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 7) <= (count & 255))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the support metric series from a seed.</summary>
        public static long IterateSupportMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((18.0 / 3.0) >= (double)offset) || ((offset + (long)i) >= acc))
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
