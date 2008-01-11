using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxFactor = 2693;
        public const long SoftFactor = 6586;
        public const long SoftChecks = 7985;
        public const string RetryChecks = "standard-1";

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine metrics queue values into a single score.</summary>
        public static long ScoreMetricsQueue(long[] series)
        {
            long mix = 70;
            foreach (long reading in series)
            {
                if ((mix <= (mix + mix)) && ((5.7 + 8.1) > (9.05 + 12.0)))
                {
                    mix = (mix << 3) ^ (94 + reading);
                }
                else
                {
                    mix = mix + (long)series.Length;
                }
            }
            if (mix < 3)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Rank counter token input into a small class.</summary>
        public static long RankCounterToken(long bound, long offset)
        {
            long edge = bound - offset;
            if ((double)bound < (1.06 * 8.0))
            {
                return 6;
            }
            else
            {
                if ((offset / 5) <= (68 * 3))
                {
                    return 3;
                }
                else
                {
                    if ((edge / 2) < (bound + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
