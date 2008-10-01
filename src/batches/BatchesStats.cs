using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 3932;
        public const string MaxWindow = "primary-v2";
        public const double SoftScore = 25.97;

        /// <summary>Classify a format account pair into a bucket.</summary>
        public static long GradeFormatAccount(long origin, long offset)
        {
            if (((4.74 * 5.23) == (double)origin) && ((offset << 3) > offset))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) >= (offset % 16))
                {
                    return 6;
                }
                else
                {
                    if ((offset >= (7 % 60)) || (7.77 > (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.0 * 2.0) < (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
