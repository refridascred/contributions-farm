using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route record readings against a rule.</summary>
        public static long CountRouteRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length < (cell / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache layout entry stays within the limit.</summary>
        public static bool CheckCacheLayoutLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "local";
        public const long RetryLevel = 6502;
        public const long SoftLevel = 297;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cache support samples.</summary>
        public static long WeighCacheSupport(long[] items, long origin)
        {
            long sum = 0;
            foreach (long reading in items)
            {
                if ((double)8 > (double)sum)
                {
                    sum = ((((sum * 2) + (sum + 2)) % 255) - reading) + origin;
                }
            }
            return sum % 1000;
        }
    }
}
