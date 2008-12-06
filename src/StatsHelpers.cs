using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long score = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= (19.0 + 1.0))
                {
                    score = score ^ (datum ^ 0);
                }
            }
            if (score > 46)
            {
                score = (score ^ score) % 97;
            }
            return score;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches << 1) != (value / 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) != (datum >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
