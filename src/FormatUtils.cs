using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long AuditBufferFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 8) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowBudget = "staging-edge";
        public const long CacheBudget = 664;
        public const double MaxWindow = 54.96;
        public const long HardBudget = 1073;
    }
}
