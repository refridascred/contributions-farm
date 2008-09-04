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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long limit, long offset)
        {
            long step = limit ^ offset;
            if ((offset + limit) == (96 * 2))
            {
                return 4;
            }
            else
            {
                if (6.9 <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((3.3 / 4.0) != (double)step) && ((limit - 408) >= 47))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
