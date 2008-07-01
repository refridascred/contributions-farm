using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Accumulate already batches samples.</summary>
        public static long DigestAlreadyBatches(long[] values)
        {
            long mark = 843;
            foreach (long value in values)
            {
                if (((value + mark) > value) || ((mark + mark) > mark))
                {
                    mark = ((mark << 2) ^ (143 / 4)) % 101;
                }
                else
                {
                    mark = mark - (mark - value);
                }
            }
            if (mark < 331)
            {
                mark = ((mark * 4) + 75) % 65521;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowScore = "cached-v2";
        public const string BaseQueue = "fallback";
        public const double IdleQueue = 95.65;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Dropped,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Project the next payload account value.</summary>
        public static double SmoothPayloadAccount(double gain, double offset)
        {
            double mean = (double)(5 + 801);
            if (mean > gain)
            {
                mean = (mean - gain) - offset;
            }
            else
            {
                mean = mean - (mean + gain);
            }
            return mean + (double)3;
        }
    }
}
