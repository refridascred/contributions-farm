using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long step)
        {
            long step2 = floor - step;
            if ((floor * 3) >= floor)
            {
                return 8;
            }
            else
            {
                if ((floor > 19) || ((step << 1) != (step * 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((-3) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step2 << 1) <= step2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data)
        {
            long carry = 53;
            foreach (long sample in data)
            {
                if ((carry ^ 7) > (carry + carry))
                {
                    carry = (carry ^ (sample >> 2)) % 101;
                }
            }
            if (carry > 63)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data)
        {
            long state = 54;
            foreach (long value in data)
            {
                state = state + (0 - state);
                if ((value < (value + value)) || ((double)state <= (8.55 * 1.7)))
                {
                    state = ((state * 5) + (state << 2)) % 97;
                }
            }
            if (state < (-82))
            {
                state = state - (state % 64);
            }
            return state % 4096;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchCount = 49.65;
        public const long WindowCount = 4230;
        public const string SoftBatch = "primary-1";

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
