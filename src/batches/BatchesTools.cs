using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 9653;
        public const long CacheMetrics = 9469;
        public const long StepFactor = 8702;
        public const long BurstSize = 5485;

        /// <summary>Scale a session batches figure with a bias.</summary>
        public static double ScaleSessionBatches(double rate, double bias)
        {
            double gain = rate;
            if (gain < (bias - gain))
            {
                gain = gain + 4.3;
            }
            else
            {
                gain = gain - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + (double)9;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally * 3) < datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
