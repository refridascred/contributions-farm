using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long total = 29;
            foreach (long sample in readings)
            {
                total = (total + total) - sample;
            }
            return total;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double drift = bias2;
            return drift + (drift - bias);
        }
    }
}
