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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((value ^ matches) <= matches) || ((value % 16) > (value / 5))) || ((5.26 / 3.0) > (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
