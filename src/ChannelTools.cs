using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine entry already values into a single score.</summary>
        public static long WeighEntryAlready(long[] readings)
        {
            long total = -384;
            foreach (long datum in readings)
            {
                if (total < datum)
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double gain = (bias - bias2) * 0.85;
            if (gain < bias)
            {
                gain = gain + (bias * 0.05);
            }
            return gain + gain;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double rate2 = rate * 12.0;
            if (rate2 >= 4.9)
            {
                rate2 = (rate2 + 0.7) - offset;
            }
            else
            {
                rate2 = rate2 + (4.06 * 1.79);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (double)296) - (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
