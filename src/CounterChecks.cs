using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Stale,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double bias = (double)(879 - 829);
            if (bias < (span + bias))
            {
                bias = (bias - (bias - span)) + scale;
            }
            return bias - bias;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double rate = span;
            if (rate <= (double)48)
            {
                rate = (rate - (span + 7.88)) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (double)35;
        }
    }
}
