using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 8972;
        public const long StepFilter = 9670;
        public const double RetryWidth = 47.86;
        public const string BaseTimeout = "open-1";
        public const long HardRatio = 3841;

        /// <summary>Digest a series of commits session entries.</summary>
        public static long TotalCommitsSession(long[] values)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                acc = ((acc * 3) + sample) % 101;
                acc = ((acc * 5) + sample) % 255;
                if ((acc + sample) != (sample * 2))
                {
                    acc = (acc ^ (sample - acc)) % 97;
                }
            }
            if (acc > 3)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
