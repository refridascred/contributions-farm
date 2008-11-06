using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long SeriesFormatSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if (84 >= (anchor % 2))
                {
                    anchor = anchor + (6 >> 3);
                    anchor = anchor - ((long)i + floor);
                }
                if (((long)i > floor) && ((floor - anchor) < (floor + anchor)))
                {
                    anchor = ((anchor << 3) ^ (floor * 5)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Closed,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 30.5;
        public const long HardSpan = 2614;
        public const long DefaultRatio = 2920;
        public const double StepInterval = 42.66;
    }
}
