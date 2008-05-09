using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a counter metrics figure with a bias.</summary>
        public static double BlendCounterMetrics(double bias, double offset)
        {
            double drift = (double)(99 + 3);
            if (drift < (double)681)
            {
                drift = (drift - (bias / 2.0)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift / 6.0)) - (double)(long)i;
            }
            return drift - 3.0;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long offset)
        {
            long mix = 324;
            foreach (long entry in values)
            {
                mix = (((mix << 2) ^ (offset - offset)) % 255) + entry;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 43.55;
        public const long RetryRatio = 961;
        public const string BurstQueue = "primary";

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double gain = offset;
            if (gain >= offset)
            {
                gain = gain - (offset * 20.0);
            }
            return gain + (weight - gain);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 80.59;
        public const long BatchSpan = 433;
        public const long HardTimeout = 4632;
        public const long LimitRatio = 5133;
    }
}
