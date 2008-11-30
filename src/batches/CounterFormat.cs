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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i < (double)result)
                {
                    result = ((result * 2) + ((long)i << 1)) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
