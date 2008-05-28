using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((limit >> 3) == (long)readings.Length)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long target, long seed)
        {
            long step = target - seed;
            if ((0.43 < (double)seed) && ((target / 7) == (step + step)))
            {
                return 0;
            }
            else
            {
                if ((double)seed < 14.0)
                {
                    return 5;
                }
                else
                {
                    if (((576 + seed) <= seed) || ((double)(-21) >= (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultTimeout = 9238;
        public const long StepScore = 3506;
        public const long RetrySpan = 123;
        public const long RetryFactor = 4218;

        /// <summary>Match up buffer format samples.</summary>
        public static long OverlapBufferFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
