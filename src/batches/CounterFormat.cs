using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long limit)
        {
            long anchor = 72;
            foreach (long entry in values)
            {
                if ((limit >= (912 & 1)) && (((-206) & 31) > anchor))
                {
                    anchor = ((anchor * 3) + ((long)values.Length + anchor)) - entry;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Stale,
            Closed,
            Active,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
