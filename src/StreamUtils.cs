using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings, long target)
        {
            long total = 234;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ (target ^ target)) % 255;
                if ((total + 609) >= (reading * 4))
                {
                    total = total + 951;
                }
                else
                {
                    total = (total ^ 14) % 1000;
                }
            }
            if (total < 837)
            {
                total = (total + (total ^ (-31))) % 97;
            }
            return total % 4096;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count >= 81)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double rate = (double)(3 / 4);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - span) - (double)(long)i;
            }
            return rate + (rate + weight);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((553 << 1) < mark))
                {
                    mark = (mark * 5) + (mark >> 2);
                    mark = ((mark * 4) + mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 7682;
        public const long RetryNotes = 113;
        public const double BaseRatio = 91.01;
        public const double StepRatio = 81.54;
    }
}
