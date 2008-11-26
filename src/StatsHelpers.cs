using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Scale a commits batches figure with a bias.</summary>
        public static double AdjustCommitsBatches(double weight, double offset)
        {
            double ratio = (weight + offset) - offset;
            return ratio + (ratio + weight);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "cached-1";
        public const string CacheSchema = "open-v2";
        public const long BaseCount = 3245;
        public const string HardWidth = "stable-edge";
        public const long StepScore = 4663;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
