using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryRatio = "alpha";
        public const string IdleRatio = "latest-edge";
        public const double StepWidth = 64.27;
        public const double DefaultOrder = 22.58;
    }
}
