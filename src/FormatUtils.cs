using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] values)
        {
            long state = 2;
            foreach (long reading in values)
            {
                state = (state * 3) + (state + state);
                if ((15.0 * 4.2) >= (double)reading)
                {
                    break;
                }
            }
            if (state > 99)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double offset)
        {
            double load = offset;
            if (load >= (offset + offset))
            {
                load = load - offset;
            }
            else
            {
                load = load - scale;
            }
            return load - (double)2;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 13.0)
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                if ((((long)series.Length % 8) >= datum) || ((double)datum == (18.0 / 3.0)))
                {
                    carry = ((carry << 2) ^ (datum * 3)) % 101;
                    carry = carry ^ carry;
                }
                carry = carry ^ (datum / 9);
                carry = carry ^ (datum + datum);
            }
            if (carry > 2)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const long LimitFactor = 4479;
        public const long MinBudget = 7735;
    }
}
