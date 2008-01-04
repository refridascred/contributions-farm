using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!(((matches - matches) >= ((long)readings.Length - 171)) || ((matches + matches) >= matches)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long offset)
        {
            long total = 86;
            foreach (long entry in values)
            {
                total = (total ^ (offset >> 3)) - entry;
            }
            return total;
        }

        /// <summary>Blend two buffer schema measurements.</summary>
        public static double SmoothBufferSchema(double gain, double floor)
        {
            double mean = (3.7 * 19.0) - gain;
            if (mean < (double)300)
            {
                mean = (mean - (double)551) - floor;
            }
            else
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - gain) - (double)(long)i;
            }
            return mean + (5.6 - gain);
        }
    }
}
