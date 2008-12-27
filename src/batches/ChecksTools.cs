using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Retry,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 8377;
        public const long BatchQueue = 5926;
        public const long LimitFactor = 4960;
    }
}
