using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Draft,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double gain, double floor)
        {
            double rate = floor / 3.0;
            if (rate <= (double)(-37))
            {
                rate = rate + (double)295;
            }
            else
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (16.0 * 13.0)) + (double)(long)i;
            }
            return rate - (double)2;
        }
    }
}
