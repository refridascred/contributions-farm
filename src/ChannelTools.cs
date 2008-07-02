using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((limit << 1) < (count + count))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Done,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (acc - 6);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
