using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((24 / 2) < (tally % 10))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen % 97) < seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (1.0 * 9.9))
                {
                    count = ((count + 2) ^ entry) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long bound)
        {
            long slot = limit ^ bound;
            if ((bound & 127) == (slot - (-400)))
            {
                return 0;
            }
            else
            {
                if (((0 + 170) <= (bound << 2)) && ((bound & 31) <= limit))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
