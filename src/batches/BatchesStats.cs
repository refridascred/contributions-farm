using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitInterval = 125;
        public const long LimitRoute = 3588;
        public const string WindowTimeout = "alpha";
        public const string MaxRoute = "fallback-v2";
        public const long BatchLevel = 3479;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((1.4 / 9.0) >= (double)count)
                {
                    count = ((count + 1) + sample) - floor;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value - 206) != (hits & 63))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long anchor = -371;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ (54 + datum)) % 1000;
            }
            if (anchor < 9)
            {
                anchor = anchor + ((long)readings.Length >> 5);
            }
            return anchor;
        }
    }
}
