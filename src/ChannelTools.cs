using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a layout token sample.</summary>
        public static long LocateLayoutTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Paused,
            Pending,
        }
    }
}
