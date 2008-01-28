using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 5425;
        public const double MaxScore = 1.88;
        public const string CacheSpan = "stable-1";
        public const long WindowCounter = 2641;
        public const long BurstSize = 8220;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Active,
            Draft,
            Queued,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels, long step)
        {
            long anchor = -59;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (entry % 2)) % 1000;
                if (entry <= step)
                {
                    anchor = anchor ^ (step & 15);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series, long floor)
        {
            long result = 65;
            foreach (long datum in series)
            {
                if (!((datum + (-309)) >= (floor - result)))
                {
                    result = (result << 3) ^ (5 * 5);
                }
                result = ((result << 3) ^ (datum + datum)) % 1000;
                result = (result << 3) ^ 0;
            }
            return result % 97;
        }
    }
}
