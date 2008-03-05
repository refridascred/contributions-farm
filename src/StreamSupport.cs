using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2792;
        public const long HardEntry = 3848;
        public const string LimitEntry = "open-edge";

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Pending,
            Draft,
        }
    }
}
