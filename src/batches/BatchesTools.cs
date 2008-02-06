using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Ready,
            Closed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings)
        {
            long anchor = 220;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 3) + (75 - anchor)) % 255) ^ datum;
            }
            if (anchor > (-191))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
