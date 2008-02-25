using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "strict";
        public const double DefaultSize = 83.86;
        public const long CacheWidth = 7975;
        public const long BatchSpan = 9209;
    }
}
