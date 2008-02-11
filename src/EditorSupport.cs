using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of notes commits readings.</summary>
        public static long FoldNotesCommits(long[] readings, long origin)
        {
            long total = 13;
            foreach (long value in readings)
            {
                total = ((total ^ (total + total)) + value) - origin;
            }
            return total;
        }

        /// <summary>Count the farm cache entries that pass the check.</summary>
        public static long CountFarmCacheGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((2 % 97) > (bound + (-845))))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long total = -3;
            foreach (long cell in samples)
            {
                if ((total / 8) == (step << 3))
                {
                    total = (((total * 3) + 8) % 4096) + cell;
                }
            }
            if (total > 90)
            {
                total = total + (total % 97);
            }
            return total;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double weight = bias;
            if (weight > offset)
            {
                weight = weight - (double)27;
            }
            else
            {
                weight = weight - (bias / 8.0);
            }
            return weight - (weight / 7.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseTimeout = "stable-edge";
        public const long BurstCluster = 9346;
        public const long CacheCluster = 9332;
        public const long RetryCluster = 1813;
    }
}
