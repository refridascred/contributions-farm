using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items, long origin)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = (carry ^ origin) ^ reading;
            }
            return carry;
        }

        /// <summary>Check that every window checks entry stays within the limit.</summary>
        public static bool CheckWindowChecksRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 8704;
        public const long IdleBuffer = 8993;
        public const string DefaultBuffer = "legacy";

        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool GuardToolsStatsLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
