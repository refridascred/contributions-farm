using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                if (7.3 >= (double)datum)
                {
                    anchor = ((anchor << 3) ^ datum) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 4096;
                }
                if (datum < anchor)
                {
                    anchor = (anchor - (anchor << 3)) % 65521;
                }
                if (((36 + anchor) < (anchor << 3)) && ((double)datum > (3.9 - 16.0)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchBudget = "strict-v2";
        public const long BatchInterval = 4842;
        public const double RetryInterval = 77.74;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate <= (ratio / 3.0))
            {
                rate = (rate + (rate * 0.28)) + floor;
            }
            return rate - ratio;
        }
    }
}
