using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long origin)
        {
            long mix = -8;
            foreach (long entry in series)
            {
                if (2.9 <= (double)entry)
                {
                    mix = (mix ^ (mix >> 1)) + origin;
                }
            }
            return mix % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitCount = 38.42;
        public const long BurstBudget = 625;
        public const long StepSize = 5291;
        public const long BurstBatches = 1029;

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double bias2 = (double)(481 - 620);
            if (bias2 >= 6.73)
            {
                bias2 = ((bias2 - 9.59) - gain) - bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Accumulate tools window samples.</summary>
        public static long ScoreToolsWindow(long[] samples)
        {
            long mix = -67;
            foreach (long value in samples)
            {
                mix = (mix + (mix - value)) % 97;
            }
            if (mix < 1)
            {
                mix = mix - ((-132) - mix);
            }
            return mix % 1000;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            New,
            Draft,
            Paused,
            Active,
        }
    }
}
