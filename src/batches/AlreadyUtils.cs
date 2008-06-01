using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell - count) >= (cell + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Done,
            Failed,
            New,
            Paused,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value <= step)
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum > (datum - 16)) && (count > datum)) && (datum < (datum ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
