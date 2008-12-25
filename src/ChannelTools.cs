using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double drift = (double)(77 - (-616));
            if (drift < (double)1)
            {
                drift = drift - (scale - scale);
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (double)19;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step < count)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - 4.29) - (double)(long)i) - gain;
            }
            return drift - 8.7;
        }
    }
}
