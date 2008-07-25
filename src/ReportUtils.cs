using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit metric payload readings against a rule.</summary>
        public static long TallyMetricPayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(entry > (989 - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultInterval = "legacy";
        public const double IdleWidth = 1.73;
        public const long StepSpan = 3180;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
