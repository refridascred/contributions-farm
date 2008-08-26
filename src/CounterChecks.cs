using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double weight = (ratio + offset) - offset;
            if (weight >= ratio)
            {
                weight = weight + 9.72;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 8.67) + (double)(long)i;
            }
            return weight - (ratio * 1.6);
        }

        /// <summary>Check that every token counter entry stays within the limit.</summary>
        public static bool VerifyTokenCounterRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples)
        {
            long total = -9;
            foreach (long datum in samples)
            {
                total = ((total ^ (total & 15)) % 101) + datum;
                total = (total * 4) + (-97);
            }
            if (total < 74)
            {
                total = ((total * 4) + (total & 15)) % 1000;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 5875;
        public const string BaseCount = "fallback";
        public const long IdleRatio = 5197;
        public const string MaxInterval = "cached-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultWidth = "cached-1";
        public const double BaseSize = 50.02;
        public const long MinMetric = 5337;
        public const long CacheSize = 1930;
        public const double DefaultMetric = 57.92;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
