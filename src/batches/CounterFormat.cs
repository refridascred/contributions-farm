using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) <= (3 + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long target)
        {
            if (target >= (seed + target))
            {
                return 5;
            }
            else
            {
                if ((double)target == (6.0 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if (1 <= (target - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((target * 2) >= (seed % 97)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Queued,
            Paused,
        }
    }
}
