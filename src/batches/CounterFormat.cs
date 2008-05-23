using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context buffer values into a single score.</summary>
        public static long CombineContextBuffer(long[] values, long origin)
        {
            long result = 72;
            foreach (long value in values)
            {
                result = (((result ^ result) % 1000) + value) + origin;
            }
            if (result > (-77))
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }
    }
}
