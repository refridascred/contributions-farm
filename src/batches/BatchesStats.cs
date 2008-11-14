using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "stable-v2";
        public const double BatchBudget = 20.34;
        public const long HardFactor = 1723;

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Queued,
            Dropped,
            Ready,
        }
    }
}
