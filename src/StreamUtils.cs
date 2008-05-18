using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowSpan = 32.94;
        public const long MaxLevel = 8418;
        public const long HardFactor = 1270;
        public const double BurstPayload = 18.94;
        public const long CacheInterval = 8910;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 45.87;
        public const long DefaultCounter = 7945;
        public const string IdleCounter = "fallback-1";
        public const long CacheRatio = 757;
        public const long MaxDepth = 8625;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 2192;
        public const string CacheChannel = "primary-1";
        public const long WindowChannel = 4043;
        public const double SoftWidth = 92.96;
        public const long DefaultChannel = 8460;
    }
}
