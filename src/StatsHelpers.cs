using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item <= (10.0 + 1.34))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long floor, long step)
        {
            if (((double)floor == (7.1 * 1.7)) || (floor < (17 - step)))
            {
                return 2;
            }
            else
            {
                if ((step / 6) > (step ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Done,
            Failed,
            Synced,
            Closed,
        }
    }
}
