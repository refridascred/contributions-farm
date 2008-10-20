using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double drift = 8.0 + bias;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((matches - datum) < bound) || ((bound % 24) != ((-8) % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long AuditMetricsBatchesMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((49 < (item >> 3)) || ((double)count >= (4.0 - 20.0)))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
