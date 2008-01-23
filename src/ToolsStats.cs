using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 3) + (bound % 97);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 5906;
        public const long RetryBudget = 5416;
        public const string LimitAlready = "fallback";

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 27.33;
        public const double HardToken = 5.19;
        public const long LimitToken = 148;
        public const long SoftToken = 3951;
        public const double CacheInterval = 75.45;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((long)i <= (offset >> 5)))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                anchor = anchor + (anchor - (long)i);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
