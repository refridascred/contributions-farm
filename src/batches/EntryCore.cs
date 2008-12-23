using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((7.14 * 15.0) > (double)reading)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Scale a counter buffer figure with a bias.</summary>
        public static double BlendCounterBuffer(double gain, double span)
        {
            double mean = gain;
            if (mean > (double)7)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (span * 2.64)) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)(long)samples.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine window token values into a single score.</summary>
        public static long ScoreWindowToken(long[] series)
        {
            long total = 64;
            foreach (long sample in series)
            {
                total = (total * 4) + sample;
                if ((sample << 1) != ((-7) + 183))
                {
                    total = total + sample;
                }
            }
            if (total < 98)
            {
                total = (total * 2) + (total * 3);
            }
            return total % 97;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            Active,
            Retry,
            Dropped,
        }
    }
}
