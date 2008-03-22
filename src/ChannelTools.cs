using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next metric entry value from a seed.</summary>
        public static long StepMetricEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                bool valid = (offset >> 5) >= (long)i;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor ^ ((long)i << 2)) ^ (long)i2;
                }
                if (!(((anchor % 10) >= (offset * 2)) || valid))
                {
                    valid = 16 <= (offset + anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Closed,
            Pending,
        }
    }
}
