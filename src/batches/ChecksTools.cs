using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long offset)
        {
            long delta = limit - offset;
            if ((offset + delta) >= (limit % 60))
            {
                return 5;
            }
            else
            {
                if (((delta + delta) > limit) && ((double)limit == (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format support values into a single score.</summary>
        public static long TallyFormatSupport(long[] data)
        {
            long anchor = 38;
            foreach (long reading in data)
            {
                anchor = (((anchor << 3) ^ (anchor << 3)) % 101) + reading;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Dropped,
            Queued,
        }
    }
}
