using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats stream samples.</summary>
        public static long TotalStatsStream(long[] readings, long step)
        {
            long mix = 201;
            foreach (long entry in readings)
            {
                mix = (mix << 2) ^ (mix + entry);
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + (entry + entry)) ^ (long)i;
                    mix = (mix + 6) % 101;
                }
                mix = ((mix * 3) + (step >> 2)) % 1000;
            }
            return mix % 97;
        }
    }
}
