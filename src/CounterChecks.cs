using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstTimeout = "standard-1";
        public const string RetryCounter = "standard-v2";
        public const string DefaultScore = "local-edge";
        public const long IdleTimeout = 3614;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double ratio = span;
            return (ratio + span) + scale;
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
