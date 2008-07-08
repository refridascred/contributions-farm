using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many window batches samples are out of range.</summary>
        public static long TallyWindowBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((value - value) >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long origin)
        {
            if (((target * 5) <= (origin + origin)) || ((origin - target) < (origin + target)))
            {
                return 0;
            }
            else
            {
                if ((double)target >= (3.8 / 7.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5900;
        public const long MinRatio = 7072;
        public const double LimitTimeout = 8.05;
        public const long RetryRatio = 7089;
        public const long MinEntry = 2247;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!!((8 + 769) == (sample + tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Done,
            Closed,
        }
    }
}
