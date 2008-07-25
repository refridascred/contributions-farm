using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Check that every session format entry stays within the limit.</summary>
        public static bool VerifySessionFormatRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((seed < (item % 2)) || ((item ^ 8) <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (target <= anchor)
                {
                    anchor = ((anchor * 4) + (long)i) % 1000;
                    anchor = (anchor << 2) ^ (61 - target);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
