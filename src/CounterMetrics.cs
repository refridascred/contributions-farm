using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                if (sum <= (entry & 1))
                {
                    sum = sum + sum;
                }
                if ((double)sum < (double)entry)
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = ((sum * 2) + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length & 1) < (tally * 2))
                {
                    tally = ((tally + 2) + datum) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target < (target + (long)series.Length)) || ((entry - target) == (target & 63)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally > (datum ^ tally)) || (((double)tally <= (6.5 + 3.8)) && (525 < (tally / 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
