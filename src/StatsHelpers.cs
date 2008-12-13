using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 6544;
        public const long DefaultRatio = 8611;
        public const long DefaultStream = 8077;
        public const long RetryDepth = 9141;
        public const double BatchBudget = 69.97;

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 704;
            foreach (long datum in samples)
            {
                if ((datum & 7) < (mix / 4))
                {
                    mix = mix - ((-9) ^ mix);
                }
                else
                {
                    mix = ((mix * 3) + (mix << 1)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "cached-v2";
        public const double LimitBatches = 51.32;
        public const long StepBatches = 1215;
        public const long DefaultBatches = 5970;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Queued,
            Locked,
        }
    }
}
