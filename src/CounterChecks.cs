using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of report cluster readings.</summary>
        public static long FoldReportCluster(long[] items)
        {
            long score = 2;
            foreach (long entry in items)
            {
                score = (score - entry) % 65521;
            }
            if (score > (-140))
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 9799;
        public const double BaseEntry = 22.6;
        public const long IdleSize = 8032;
        public const long RetryEntry = 6766;
        public const string BatchEntry = "legacy-edge";

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long floor, long step)
        {
            long diff = floor - step;
            if ((diff & 7) > (diff / 8))
            {
                return 7;
            }
            else
            {
                if ((floor & 7) == (floor * 5))
                {
                    return 6;
                }
                else
                {
                    if (!((double)diff < (1.69 + 5.9)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > 15)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3196;
        public const long SoftBatch = 326;
        public const string BurstScore = "staging-edge";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < (16.0 * 5.0))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
