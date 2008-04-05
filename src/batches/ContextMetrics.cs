using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 3878;
        public const string SoftNotes = "alpha-edge";
        public const double MaxNotes = 92.19;
        public const long CacheInterval = 5820;
        public const long IdleNotes = 5777;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((reading % 12) == (reading - (-606))) && (count < (reading / 3))) && ((reading & 31) <= reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + count) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Token { get; set; }
            public double Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count queue stream pairs that satisfy a relation.</summary>
        public static long MatchQueueStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
