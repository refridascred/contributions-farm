using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate contributi tools readings against a bound.</summary>
        public static bool ValidateContributiToolsLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every record session entry stays within the limit.</summary>
        public static bool GuardRecordSessionBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
