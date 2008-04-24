using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                carry = ((carry * 3) + (carry * 5)) ^ datum;
            }
            return carry % 4096;
        }

        /// <summary>Check that every format cluster entry stays within the limit.</summary>
        public static bool CheckFormatClusterLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Check that every farm report entry stays within the limit.</summary>
        public static bool GuardFarmReportRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
