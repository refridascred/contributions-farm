using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long origin)
        {
            if ((target % 100) <= origin)
            {
                return 3;
            }
            else
            {
                if (1.2 >= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((origin & 15) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many tools context samples are out of range.</summary>
        public static long MeasureToolsContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((321 + datum) >= (datum / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Ready,
            Draft,
            Queued,
        }
    }
}
