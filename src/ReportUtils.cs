using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the channel command series from a seed.</summary>
        public static long DeriveChannelCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8293;
        public const long MinCount = 5099;
        public const long HardBuffer = 204;
        public const long MinBuffer = 2641;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((6.0 / 7.0) <= (double)bound)
                {
                    anchor = ((anchor * 4) + (anchor ^ anchor)) % 97;
                }
                anchor = (anchor - (416 - (long)i)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the farm queue series from a seed.</summary>
        public static long RollFarmQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Idle,
            Retry,
        }
    }
}
