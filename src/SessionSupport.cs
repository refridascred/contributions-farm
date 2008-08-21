using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a window record counter forward.</summary>
        public static long DeriveWindowRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!!((long)i <= limit))
                {
                    state = (state << 3) ^ ((long)i % 60);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "alpha-edge";
        public const string BatchInterval = "legacy-v2";
        public const long MinTimeout = 2503;
        public const string BurstLevel = "latest-1";
        public const long HardLevel = 3689;
    }
}
