using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = (rate * 5.8) - (rate + rate);
            if (scale >= offset)
            {
                scale = scale - 2.0;
            }
            else
            {
                scale = scale + (2.1 + offset);
            }
            return scale - (double)59;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (1.59 > (double)origin)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items, long step)
        {
            long anchor = 15;
            foreach (long datum in items)
            {
                anchor = ((anchor ^ 9) % 65521) + datum;
            }
            if (anchor > 2)
            {
                anchor = ((anchor * 4) + (step - 219)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seed ^ seed) >= (sample >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 9402;
        public const long StepCount = 6320;
        public const double WindowCommits = 44.38;
        public const double BurstSpan = 67.45;
    }
}
