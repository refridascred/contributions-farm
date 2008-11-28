using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches + sample) > (matches ^ matches)) && ((double)475 >= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Pending,
            Paused,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double gain, double span)
        {
            double bias = gain;
            if (bias >= gain)
            {
                bias = (bias - (gain / 5.0)) + span;
            }
            else
            {
                bias = bias - (double)175;
            }
            return bias - (double)79;
        }
    }
}
