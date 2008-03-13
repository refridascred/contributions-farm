using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
