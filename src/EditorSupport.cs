using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long anchor = 932;
            foreach (long entry in readings)
            {
                if (!((bound << 3) >= (bound + 1)))
                {
                    anchor = (anchor + 92) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Draft,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (861 < cell)
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Stale,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + 596) > (value - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
