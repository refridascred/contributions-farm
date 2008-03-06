using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias + (19.0 - rate);
            }
            return bias + (double)(-9);
        }

        /// <summary>Combine account context values into a single score.</summary>
        public static long DigestAccountContext(long[] readings, long step)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                total = ((((total << 2) ^ total) % 97) ^ entry) - step;
            }
            return total;
        }
    }
}
