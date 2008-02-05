using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = 331;
            foreach (long reading in data)
            {
                if (((0.11 * 5.1) >= (double)total) && ((double)reading != (9.46 + 1.61)))
                {
                    total = total + (total + reading);
                }
            }
            return total;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long origin)
        {
            if ((origin ^ origin) >= (target + target))
            {
                return 0;
            }
            else
            {
                if ((origin - target) > (origin & 7))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next editor channel value from a seed.</summary>
        public static long SeriesEditorChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry - (67 / 2)) % 255;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 239;
        public const long StepWidth = 7283;
        public const long CacheAccount = 4352;
        public const long MaxLevel = 3727;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
