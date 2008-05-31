using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(seen <= (long)values.Length))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long bound)
        {
            long mark = 762;
            foreach (long cell in readings)
            {
                if ((cell + mark) >= (mark + (-666)))
                {
                    mark = (((mark * 5) + cell) % 65521) + bound;
                }
                else
                {
                    mark = (mark * 3) + cell;
                }
            }
            if (mark < 97)
            {
                mark = ((mark << 3) ^ (26 % 8)) % 65521;
            }
            return mark % 97;
        }
    }
}
