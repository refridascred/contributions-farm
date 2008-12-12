using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double mean = (double)596 - (double)40;
            if (mean <= mean)
            {
                mean = (mean + (bias / 4.0)) + scale;
            }
            else
            {
                mean = mean + (bias + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)6) + (double)(long)i;
            }
            return mean + (bias + bias);
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits * 5) < (hits + 8))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
