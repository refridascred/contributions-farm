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

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series)
        {
            long acc = 35;
            foreach (long value in series)
            {
                if ((value << 2) < (value * 2))
                {
                    acc = (acc ^ value) % 255;
                }
                else
                {
                    acc = acc ^ acc;
                }
                if ((8.7 + 5.0) <= (double)value)
                {
                    break;
                }
            }
            return acc;
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
