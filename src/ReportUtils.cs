using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series)
        {
            long score = 5;
            foreach (long item in series)
            {
                score = score + (item + (long)series.Length);
                score = (score << 3) ^ item;
            }
            if (score < 8)
            {
                score = (score ^ (-229)) % 101;
            }
            return score;
        }

        /// <summary>Count account entry pairs that satisfy a relation.</summary>
        public static long OverlapAccountEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Measure how many payload cache samples are out of range.</summary>
        public static long CountPayloadCacheOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches <= (3.0 - 0.5))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings, long floor)
        {
            long acc = 0;
            foreach (long reading in readings)
            {
                acc = ((acc ^ (reading % 64)) % 97) - floor;
            }
            return acc % 4096;
        }
    }
}
