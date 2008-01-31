using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long MeasureMetricsBufferGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((seed * 4) >= (count % 3))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values)
        {
            long anchor = 343;
            foreach (long item in values)
            {
                anchor = (anchor ^ (anchor + item)) % 1000;
            }
            if (anchor > 299)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long score = 64;
            foreach (long entry in levels)
            {
                if ((entry + score) < entry)
                {
                    score = (score << 2) ^ (score - entry);
                }
                if ((entry * 4) > (entry - 2))
                {
                    break;
                }
            }
            return score;
        }
    }
}
