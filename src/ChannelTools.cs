using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 397;
        public const double MaxFactor = 0.42;
        public const double WindowLevel = 32.93;
        public const long HardFarm = 2965;
        public const long SoftFarm = 7369;

        /// <summary>Look up the position of a farm layout sample.</summary>
        public static long LookupFarmLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            New,
            Ready,
        }
    }
}
