using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a commits metric reading.</summary>
        public static double AdjustCommitsMetric(double bias, double span)
        {
            double drift = span;
            if (drift <= (double)(-510))
            {
                drift = (drift - 9.0) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                if ((acc + (-6)) < (acc + (-36)))
                {
                    acc = ((acc + acc) % 255) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
