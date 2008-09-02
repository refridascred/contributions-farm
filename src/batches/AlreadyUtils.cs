using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the entry layout entries that pass the check.</summary>
        public static long AuditEntryLayoutHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((count - target) <= target) && (((10.0 / 6.0) < (double)count) && ((count >> 2) <= count)))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 1944;
        public const long RetryProfile = 7289;
        public const string BatchProfile = "strict-1";

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mix = 68;
            foreach (long item in items)
            {
                mix = ((mix << 3) ^ (mix & 15)) ^ item;
                mix = ((mix * 3) + mix) % 255;
                mix = (mix << 2) ^ 181;
            }
            return mix;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double gain = 5.61;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)14) + (double)(long)i) - offset;
            }
            return gain - rate;
        }
    }
}
