using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Count session entry pairs that satisfy a relation.</summary>
        public static long PairSessionEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 60.84;
        public const long MaxToken = 8329;
        public const double MinTimeout = 74.9;
        public const long LimitScore = 9213;
    }
}
