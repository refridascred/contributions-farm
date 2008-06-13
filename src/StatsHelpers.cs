using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every layout tools entry stays within the limit.</summary>
        public static bool ValidateLayoutToolsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool VerifyBatchSessionRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of filter queue readings.</summary>
        public static long TotalFilterQueue(long[] series)
        {
            long mark = 222;
            foreach (long value in series)
            {
                mark = mark - (value + mark);
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((2.1 + 3.73) > (double)matches)
                {
                    matches = ((matches + 3) + sample) - target;
                }
            }
            return matches;
        }
    }
}
