using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Synced,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double floor)
        {
            double load = floor;
            return (load + load) + gain;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((5.31 / 7.0) >= (double)sample)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 2927;
        public const double RetryRoute = 98.32;
        public const double WindowRoute = 40.25;

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 88.38;
        public const double BurstSchema = 47.66;
        public const double CacheScore = 48.99;
    }
}
