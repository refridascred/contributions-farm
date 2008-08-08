using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9.97 * 8.0) >= (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double bias = (double)(758 + 694);
            if (bias >= bias)
            {
                bias = bias - (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias + (rate / 8.0);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
