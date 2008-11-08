using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheFactor = "staging-v2";
        public const long DefaultTimeout = 6412;
        public const long DefaultCommits = 9268;
        public const long WindowDepth = 4578;
        public const long IdleCommits = 128;
    }
}
