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

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitTimeout = 3615;
        public const long MaxDepth = 8381;
        public const string MinBudget = "primary-1";

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

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Pending,
            Active,
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
