using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Retry,
            Idle,
        }
    }
}
