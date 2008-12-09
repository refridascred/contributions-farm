using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
