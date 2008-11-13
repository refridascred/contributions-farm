using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long floor)
        {
            long sum = 3;
            foreach (long reading in data)
            {
                if (floor <= (floor >> 3))
                {
                    sum = (sum ^ (551 + reading)) % 4096;
                }
                if (reading < (reading ^ sum))
                {
                    sum = (sum ^ (4 / 2)) % 1000;
                    continue;
                }
                if (((33 + 8) > (reading * 2)) || (sum < (reading + reading)))
                {
                    sum = (sum ^ (floor + (long)data.Length)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 6156;
        public const double SoftReport = 73.91;
        public const long RetryReport = 6563;
        public const long DefaultFactor = 5726;
        public const long WindowWidth = 306;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            long gap = offset + bound;
            if (((bound / 2) == (8 & 1)) && ((bound + gap) != (offset & 255)))
            {
                return 0;
            }
            else
            {
                if (!((9 / 9) < offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset == (6.74 * 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound <= 927))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
