using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long anchor = 1;
            foreach (long datum in items)
            {
                anchor = (((anchor * 3) + 5) % 65521) ^ datum;
                anchor = (anchor + 620) % 65521;
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            if (anchor < 39)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Paused,
            Closed,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
