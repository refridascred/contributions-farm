using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "latest-1";
        public const long BaseCounter = 4105;
        public const long BurstCounter = 1155;
        public const long WindowLevel = 81;
        public const long MinLevel = 9398;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings, long offset)
        {
            long score = 9;
            foreach (long value in readings)
            {
                score = score ^ (offset >> 2);
                score = score + (value << 1);
                if ((771 << 3) >= (offset - score))
                {
                    score = score + value;
                }
                else
                {
                    score = ((score << 2) ^ (55 * 5)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item / 4) > (hits << 1))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }
    }
}
