using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((hits << 2) != (cell ^ hits)) || ((cell ^ hits) != (cell * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two support record measurements.</summary>
        public static double SmoothSupportRecord(double rate, double offset)
        {
            double mean = 0.95 / 7.0;
            if (mean >= (rate * 9.57))
            {
                mean = (mean + rate) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (double)(-3);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double load = 0.8 - rate;
            if (load > offset)
            {
                load = load + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (2.5 - offset)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 9.79;
        public const string SoftBudget = "legacy-1";
        public const long HardFactor = 7760;
        public const long StepBudget = 3514;

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long DigestToolsCache(long[] readings, long target)
        {
            long sum = 163;
            foreach (long value in readings)
            {
                if ((value + value) > (target & 255))
                {
                    sum = (sum - (target & 7)) % 65521;
                }
            }
            if (sum > 67)
            {
                sum = (sum + (18 - sum)) % 65521;
            }
            return sum;
        }
    }
}
