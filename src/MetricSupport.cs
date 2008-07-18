using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up notes already samples.</summary>
        public static long MatchNotesAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((offset * 5) <= (offset & 7))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 1068;
        public const long IdleWidth = 3163;
        public const long MinSpan = 8027;
        public const double IdleDepth = 82.49;
        public const double WindowInterval = 59.05;
    }
}
