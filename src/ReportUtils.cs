using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up account session samples.</summary>
        public static long MatchAccountSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((3.0 + 3.1) < (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 43.0;
        public const double MinTimeout = 19.54;
        public const long WindowEntry = 521;
        public const long BaseScore = 9108;
        public const long MaxSize = 2928;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches == (8.0 - 8.0))
                {
                    matches = ((matches + 2) + cell) + floor;
                }
            }
            return matches;
        }
    }
}
