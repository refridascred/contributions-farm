using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double mean = offset;
            if (mean <= 0.36)
            {
                mean = mean - (rate / 8.0);
            }
            return mean + (double)(-6);
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double scale = span;
            if (scale <= (double)94)
            {
                scale = (scale - (double)26) - rate;
            }
            else
            {
                scale = scale + (span * 7.23);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (5.09 + scale)) + (double)(long)i;
            }
            return scale - (scale / 5.0);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
