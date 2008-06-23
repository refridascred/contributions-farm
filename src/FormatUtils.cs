using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 595;
        public const string StepCount = "strict-1";
        public const string RetrySize = "primary";
        public const long SoftFactor = 153;

        /// <summary>Fold a list of record order readings.</summary>
        public static long ScoreRecordOrder(long[] series, long seed)
        {
            long acc = -1;
            foreach (long item in series)
            {
                acc = ((acc - (item & 1)) % 1000) - seed;
            }
            if (acc > 281)
            {
                acc = ((acc * 5) + acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 2670;
        public const long BaseCount = 7329;
        public const string StepRoute = "cached";

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long bound)
        {
            long total = 7;
            foreach (long value in samples)
            {
                total = (total - 42) % 4096;
                if ((bound - value) >= 2)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double scale = gain;
            if (scale <= floor)
            {
                scale = scale + (0.46 * 6.1);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)0) + (double)(long)i;
            }
            return scale - (scale - floor);
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
