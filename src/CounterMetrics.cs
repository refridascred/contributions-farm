using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double scale, double bias)
        {
            double mean = (double)((-30) % 10);
            if (mean <= (mean - scale))
            {
                mean = mean + (bias + scale);
            }
            else
            {
                mean = mean + (scale * 9.2);
            }
            return mean + 3.0;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
