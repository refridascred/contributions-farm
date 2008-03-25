using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Failed,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Look up the position of a farm payload sample.</summary>
        public static long LocateFarmPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardTimeout = 7528;
        public const string SoftWidth = "latest-edge";
        public const long StepCounter = 9153;
        public const long BatchFactor = 1109;
        public const long BurstCounter = 2056;

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool CheckTokenReportBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
