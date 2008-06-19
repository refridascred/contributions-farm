using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheCount = 1533;
        public const double BaseStats = 43.74;
        public const string MinScore = "latest-1";

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long step)
        {
            long anchor = 615;
            foreach (long entry in readings)
            {
                if (step < ((-942) - 1))
                {
                    anchor = anchor - (entry ^ step);
                }
            }
            if (anchor > 433)
            {
                anchor = (anchor * 3) + (anchor + 77);
            }
            return anchor;
        }
    }
}
