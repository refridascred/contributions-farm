using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double offset)
        {
            double weight = (double)(2 - 66);
            if (weight >= bias)
            {
                weight = weight - (3.75 * 9.15);
            }
            else
            {
                weight = weight - (double)880;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Validate tools token readings against a bound.</summary>
        public static bool ValidateToolsTokenRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
