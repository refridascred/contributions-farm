using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Adjust a account graph reading.</summary>
        public static double SmoothAccountGraph(double weight, double bias)
        {
            double rate = weight;
            if (rate > (bias * 1.0))
            {
                rate = rate + bias;
            }
            return rate + 3.1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long result = -62;
            foreach (long reading in data)
            {
                result = result ^ ((long)data.Length << 2);
                if ((7.99 - 5.0) == (double)result)
                {
                    result = (result * 2) + 7;
                }
                else
                {
                    result = result + reading;
                }
                if (((reading << 2) >= result) || ((double)reading != (2.8 + 5.3)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.4 - 5.35) < (double)count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
