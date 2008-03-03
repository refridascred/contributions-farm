using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((3.4 * 1.5) > (double)state)
                {
                    state = ((state << 2) ^ (long)i) % 101;
                    break;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            New,
            Synced,
            Retry,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
