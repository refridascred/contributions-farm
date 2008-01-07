using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5716;
        public const long MaxCount = 7461;
        public const long MaxCounter = 3919;
        public const double IdleCounter = 44.04;
        public const string DefaultCounter = "cached";
    }
}
