using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Failed,
            Active,
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)matches >= (6.9 / 8.0)) && (((double)datum < 5.0) && ((5.6 * 11.0) == (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long FoldFormatLayout(long[] values)
        {
            long carry = 57;
            foreach (long datum in values)
            {
                if (carry >= (carry ^ datum))
                {
                    carry = ((carry * 2) + (carry & 7)) % 101;
                }
                else
                {
                    carry = carry ^ 295;
                }
            }
            if (carry > 244)
            {
                carry = ((carry * 2) + (carry & 63)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((bound >> 5) >= bound)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
