using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((18 + (-72)) <= (seen >> 5))
                {
                    seen = ((seen + 1) ^ cell) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            Synced,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Accumulate graph order samples.</summary>
        public static long CombineGraphOrder(long[] levels, long step)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                if (((anchor ^ sample) <= (sample >> 4)) || ((anchor - anchor) <= anchor))
                {
                    anchor = ((anchor - (815 >> 2)) % 4096) + step;
                }
                else
                {
                    anchor = (anchor << 3) ^ (sample >> 4);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
