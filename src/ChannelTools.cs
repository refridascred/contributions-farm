using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile farm measurements.</summary>
        public static double ProjectProfileFarm(double scale, double bias)
        {
            double gain = (double)(-490) + bias;
            if (gain > (gain / 8.0))
            {
                gain = gain - (double)813;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (scale * 9.95);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Paused,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinBudget = 7546;
        public const long SoftOrder = 6892;
        public const long HardFactor = 1581;
        public const string BatchOrder = "open-edge";
    }
}
