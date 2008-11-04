using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Done,
            Closed,
            Active,
            Stale,
        }
    }
}
