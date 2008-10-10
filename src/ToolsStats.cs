using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit batches support readings against a rule.</summary>
        public static long CountBatchesSupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading >> 1) < (reading & 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheLevel = "legacy-1";
        public const double MinBatches = 43.98;
        public const double DefaultInterval = 18.8;
        public const string BatchBatches = "fallback-v2";
        public const long RetryBatches = 3759;

        /// <summary>Find the first account editor entry that matches the target.</summary>
        public static long FindAccountEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1113;
        public const double BaseWidth = 9.13;
        public const long BurstEntry = 698;
        public const long MinEntry = 1449;

        /// <summary>Fold a list of queue stats readings.</summary>
        public static long DigestQueueStats(long[] data, long step)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = (((result * 2) + (95 ^ step)) % 65521) ^ entry;
            }
            if (result < 23)
            {
                result = (result << 2) ^ (step + step);
            }
            return result;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
