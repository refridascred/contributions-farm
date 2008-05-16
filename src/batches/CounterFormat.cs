using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double scale = gain;
            if (scale > (double)95)
            {
                scale = (scale - (double)62) - span;
            }
            return scale - 7.42;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Done,
            Retry,
            Synced,
            Queued,
        }
    }
}
