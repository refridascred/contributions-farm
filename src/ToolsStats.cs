using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 1433;
        public const string BaseScore = "fallback";
        public const double IdleInterval = 6.08;

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double bias = offset;
            if (bias <= offset)
            {
                bias = (bias + offset) + gain;
            }
            return bias - (double)63;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 6513;
        public const long RetryFormat = 9652;
        public const string BurstInterval = "primary-1";
        public const double CacheRatio = 63.85;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
