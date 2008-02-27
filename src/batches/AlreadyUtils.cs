using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((506 % 64) <= floor) || ((11.0 / 4.0) >= (double)floor))
                {
                    mix = (mix << 3) ^ (long)i;
                }
                mix = (mix - floor) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((5.09 * 1.18) == (double)bound)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = (total - ((long)i - total)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double weight = (bias - bias) + floor;
            if (weight >= (floor - bias))
            {
                weight = weight - (floor - floor);
            }
            else
            {
                weight = weight - bias;
            }
            return weight + 2.9;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item <= (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
