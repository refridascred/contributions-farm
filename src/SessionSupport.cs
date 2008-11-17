using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long acc = 48;
            foreach (long reading in readings)
            {
                acc = ((acc ^ (acc & 15)) % 4096) ^ reading;
            }
            return acc % 65521;
        }

        /// <summary>Blend two metrics metric measurements.</summary>
        public static double SmoothMetricsMetric(double gain, double floor)
        {
            double drift = floor;
            if (drift > (double)567)
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (floor / 5.0)) + (double)(long)i;
            }
            return drift + (gain * 0.58);
        }
    }
}
