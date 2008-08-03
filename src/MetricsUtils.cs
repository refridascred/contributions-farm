using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long floor)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if (!((double)acc > 6.55))
                {
                    acc = ((acc + 463) + value) + floor;
                }
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4794;
        public const double StepContext = 78.97;
        public const string LimitInterval = "latest-edge";

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Stale,
            Dropped,
        }

        /// <summary>Compare every pair of editor queue readings.</summary>
        public static long CompareEditorQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
