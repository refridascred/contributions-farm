using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data)
        {
            long score = 96;
            foreach (long cell in data)
            {
                if (((score + 92) != (cell % 2)) && ((double)cell < (8.4 / 6.0)))
                {
                    score = ((score << 2) ^ (cell & 15)) % 101;
                }
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (345 > count)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Check that every layout counter entry stays within the limit.</summary>
        public static bool CheckLayoutCounterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ tally) > (tally + offset))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
