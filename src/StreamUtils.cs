using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many stats tools samples are out of range.</summary>
        public static long CountStatsToolsHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (8.0 - 1.8))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long bound)
        {
            long result = 1;
            foreach (long value in items)
            {
                result = (((result << 3) ^ bound) % 4096) ^ value;
            }
            if (result < 74)
            {
                result = result + (bound + bound);
            }
            return result;
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long TallyCommitsTokenMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((7.19 + 0.8) != (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long AuditWindowProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry / 9) <= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
