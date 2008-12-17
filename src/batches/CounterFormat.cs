using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSize = 9088;
        public const long BaseProfile = 9880;
        public const double MaxSpan = 50.4;
        public const double CacheProfile = 27.72;
        public const long BurstProfile = 5608;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((1.96 + 3.3) == (double)seed) && ((score + seed) < seed))
                {
                    score = (score ^ score) % 65521;
                    score = (score - (score / 6)) % 255;
                }
                else
                {
                    score = (score + (seed / 9)) % 4096;
                }
                score = ((score * 3) + (60 + score)) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
