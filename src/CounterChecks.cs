using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstTimeout = "standard-1";
        public const string RetryCounter = "standard-v2";
        public const string DefaultScore = "local-edge";
        public const long IdleTimeout = 3614;

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long sum = 6;
            foreach (long item in levels)
            {
                sum = (((sum << 3) ^ 44) % 255) - item;
                sum = (sum + (sum * 3)) % 101;
            }
            if (sum > 0)
            {
                sum = (sum + ((long)levels.Length - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long floor2)
        {
            if ((1.32 <= (double)floor2) && ((floor2 - floor) >= (818 ^ floor)))
            {
                return 8;
            }
            else
            {
                if ((floor2 > floor) || ((floor + floor) >= 9))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
