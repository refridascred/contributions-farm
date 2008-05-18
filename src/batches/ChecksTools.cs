using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Retry,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels)
        {
            long score = 94;
            foreach (long datum in levels)
            {
                if ((double)score < (9.63 - 4.69))
                {
                    score = ((score << 2) ^ (datum + datum)) % 101;
                }
                score = (score ^ (440 - (long)levels.Length)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 9) >= (reading + matches))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
