using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + (346 >> 4)) % 255;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 9797;
        public const string DefaultContributi = "staging-v2";
        public const long HardWidth = 5966;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 64) <= (offset ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
