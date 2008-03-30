using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor << 3) ^ (target / 5)) % 4096) - (long)i2;
                }
                if (!((anchor % 10) != ((long)i << 2)))
                {
                    anchor = anchor - (anchor / 8);
                }
                else
                {
                    anchor = ((anchor * 3) + target) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long acc = 185;
            foreach (long entry in data)
            {
                acc = (acc ^ (5 % 2)) % 97;
                acc = acc + entry;
            }
            return acc % 65521;
        }
    }
}
