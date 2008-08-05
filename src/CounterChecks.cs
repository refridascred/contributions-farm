using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed >> 5) < (matches + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 1.5)) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double drift = (double)(7 << 3);
            if (drift >= (double)938)
            {
                drift = (drift - floor) + gain;
            }
            return drift - floor;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Locked,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Project the next batches counter value.</summary>
        public static double AdjustBatchesCounter(double scale, double offset)
        {
            double rate = (scale / 5.0) + (4.5 * 3.8);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (offset + scale)) - (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 1958;
        public const long BurstStats = 6615;
        public const string WindowStats = "stable-1";
        public const long MinStats = 1545;
    }
}
