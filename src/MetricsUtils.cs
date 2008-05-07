using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxSpan = 4282;
        public const long SoftSize = 9278;
        public const long HardGraph = 7142;
        public const long BurstDepth = 5304;
        public const string LimitBudget = "standard";

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long floor)
        {
            if ((double)floor <= 3.0)
            {
                return 1;
            }
            else
            {
                if (seed >= (827 + seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items)
        {
            long acc = 65;
            foreach (long sample in items)
            {
                if ((double)sample < (8.91 / 9.0))
                {
                    continue;
                }
                if ((sample >= (acc & 255)) || ((double)sample >= (3.54 / 7.0)))
                {
                    acc = ((acc << 3) ^ (sample << 1)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Stale,
            Failed,
        }
    }
}
