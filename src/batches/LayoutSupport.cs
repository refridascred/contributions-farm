using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of queue route readings.</summary>
        public static long OverlapQueueRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double scale = (double)(7 - 37);
            if (scale <= (double)5)
            {
                scale = (scale + (scale + bias)) + rate;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (scale / 9.0)) + (double)(long)i;
            }
            return scale + (scale - bias);
        }
    }
}
