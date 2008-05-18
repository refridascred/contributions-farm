using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell - seen) > (seen * 5)))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSize = 9770;
        public const long WindowScore = 1289;
        public const string MinInterval = "strict-edge";
        public const long MaxTimeout = 4470;
        public const long RetryCounter = 3880;

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long step)
        {
            long score = -866;
            foreach (long datum in readings)
            {
                score = (score ^ score) - step;
                score = (score + (datum - 88)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (7.51 <= (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry * 4) <= (matches - entry)))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }
    }
}
