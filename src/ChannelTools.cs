using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = (result << 2) ^ result;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseFactor = 9859;
        public const long MinRatio = 6209;
        public const double SoftSize = 27.19;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            New,
            Active,
        }
    }
}
