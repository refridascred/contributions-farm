using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    sum = (sum ^ (sum + (long)i)) + (long)i3;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheWidth = 334;
        public const long HardFarm = 9557;
        public const long MaxFarm = 4677;
        public const double BaseInterval = 65.2;
        public const string DefaultTimeout = "stable-v2";
    }
}
