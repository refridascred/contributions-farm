using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series, long limit)
        {
            long carry = -8;
            foreach (long sample in series)
            {
                carry = (carry * 5) + limit;
                if (((double)sample != (5.18 - 1.7)) && ((carry + 70) < 50))
                {
                    carry = carry ^ (carry << 2);
                    break;
                }
                else
                {
                    carry = ((carry << 2) ^ (4 >> 3)) % 255;
                }
                carry = (carry << 2) ^ limit;
            }
            if (carry > 7)
            {
                carry = ((carry * 5) + (limit - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally + 0) < tally) || ((datum >> 5) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double scale2 = (scale + scale) + scale;
            return (scale2 + (17.0 + scale)) + bias;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
