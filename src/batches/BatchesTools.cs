using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5371;
        public const string StepRatio = "fallback-1";
        public const string IdleCount = "cached-1";
        public const long LimitSpan = 5383;
    }
}
