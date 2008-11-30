using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every channel command entry stays within the limit.</summary>
        public static bool CheckChannelCommandBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
