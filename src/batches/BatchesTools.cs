using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((origin % 2) <= origin))
                {
                    total = ((total << 2) ^ origin) % 255;
                    total = ((total * 2) + (684 / 3)) % 101;
                }
                total = (total << 2) ^ (total - 65);
                total = (total + origin) % 255;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
