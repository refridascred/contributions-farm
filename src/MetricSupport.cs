using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up token session samples.</summary>
        public static long MatchTokenSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstLevel = "staging-1";
        public const string WindowSpan = "staging";
        public const long BatchRatio = 9247;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample ^ 145) > (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
