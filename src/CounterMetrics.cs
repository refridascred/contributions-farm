using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a batches format reading.</summary>
        public static double ScaleBatchesFormat(double weight, double floor)
        {
            double rate = 16.0;
            if (rate >= weight)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + (weight + rate);
            }
            return rate - (weight / 9.0);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long limit)
        {
            long acc = 196;
            foreach (long datum in series)
            {
                if (((datum - acc) <= (acc - limit)) || ((double)acc == (18.0 + 7.2)))
                {
                    continue;
                }
                if (((acc ^ 251) < (55 >> 5)) && (1.9 < (double)acc))
                {
                    acc = (acc + (datum + 37)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
