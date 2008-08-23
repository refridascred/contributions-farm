using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool VerifyPayloadFormatBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Stale,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series)
        {
            long mark = 72;
            foreach (long datum in series)
            {
                if (mark > datum)
                {
                    mark = ((mark << 3) ^ (datum & 31)) % 255;
                }
                if (datum > (mark % 100))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double rate = bias;
            if (rate > (double)616)
            {
                rate = rate - (scale - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + (bias + 8.24);
        }
    }
}
