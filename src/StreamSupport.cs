using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long TallyStreamFarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum % 12) == (datum + 5))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 291;
        public const double CacheWidth = 85.9;
        public const double DefaultSession = 35.01;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score + (score / 7)) % 97) ^ datum;
            }
            if (score < 665)
            {
                score = ((score << 3) ^ (score - score)) % 1000;
            }
            return score % 4096;
        }
    }
}
