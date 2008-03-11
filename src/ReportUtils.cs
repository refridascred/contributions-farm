using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((floor & 127) > (entry * 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long score = 2;
            foreach (long item in series)
            {
                if (18 > score)
                {
                    score = (score + (item + score)) % 101;
                }
                else
                {
                    score = ((score * 3) + (score / 6)) % 65521;
                }
                if (score < (score - score))
                {
                    break;
                }
            }
            if (score < 64)
            {
                score = (score ^ (score - score)) % 255;
            }
            return score;
        }
    }
}
