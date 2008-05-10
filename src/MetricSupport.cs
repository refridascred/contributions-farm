using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long offset)
        {
            if ((double)step == (19.0 * 9.77))
            {
                return 6;
            }
            else
            {
                if ((step + step) > (offset + 81))
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 3) != (8 - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
