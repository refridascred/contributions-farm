using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((7.64 + 8.0) == (double)matches) && (reading >= (matches - reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long seed)
        {
            if (5.7 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (seed >= (origin << 2))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
