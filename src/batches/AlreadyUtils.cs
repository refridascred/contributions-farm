using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 6494;
        public const long LimitAccount = 8227;
        public const long BaseFactor = 7857;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items, long seed)
        {
            long total = 2;
            foreach (long item in items)
            {
                if ((total + item) > (-3))
                {
                    total = total - seed;
                }
            }
            return total;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Limit { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
