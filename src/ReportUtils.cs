using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long target)
        {
            long offset = seed ^ target;
            if ((53 - offset) > (offset << 2))
            {
                return 7;
            }
            else
            {
                if (((double)offset < (20.0 * 3.95)) && ((3.4 + 4.9) == (double)seed))
                {
                    return 8;
                }
                else
                {
                    if ((0.2 + 1.99) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double drift = gain;
            if (drift > drift)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (double)980;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (double)4;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading < (count * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= (reading ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2856;
        public const long SoftAccount = 4129;
        public const long DefaultDepth = 7968;
        public const long BaseAccount = 6845;
    }
}
