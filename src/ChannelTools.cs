using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Ready,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Check that every batch format entry stays within the limit.</summary>
        public static bool CheckBatchFormatRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > 3.1)
            {
                bias2 = (bias2 + (double)24) + bias;
            }
            return bias2 - (double)0;
        }
    }
}
