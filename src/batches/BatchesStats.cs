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

        /// <summary>Look up the position of a commits notes sample.</summary>
        public static long FindCommitsNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
