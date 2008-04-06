using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long score = 3;
            foreach (long item in values)
            {
                score = (((score << 3) ^ ((long)values.Length % 64)) % 4096) + item;
                if ((double)score > (0.67 * 4.7))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values, long floor)
        {
            long sum = 402;
            foreach (long sample in values)
            {
                if (!((double)sum < 1.7))
                {
                    sum = (sum + floor) % 4096;
                }
                else
                {
                    sum = (sum - (sample + sum)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long state = 819;
            foreach (long datum in series)
            {
                state = state ^ (datum & 15);
                state = ((state << 3) ^ (seed ^ state)) % 4096;
                state = (state + datum) % 101;
            }
            if (state > 2)
            {
                state = (state - (state / 6)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 15.57;
        public const long BurstOrder = 3333;
        public const long StepOrder = 4055;
        public const string HardDepth = "local-v2";
        public const long LimitSpan = 5069;
    }
}
