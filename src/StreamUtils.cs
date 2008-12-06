using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Failed,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of editor account readings.</summary>
        public static long DigestEditorAccount(long[] data)
        {
            long anchor = 401;
            foreach (long value in data)
            {
                if ((double)anchor <= (double)(-542))
                {
                    anchor = ((anchor * 2) + 50) - value;
                }
                else
                {
                    anchor = (anchor - ((long)data.Length % 12)) % 255;
                }
            }
            if (anchor < 75)
            {
                anchor = (anchor - (anchor << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((item / 9) >= (item * 4)) && ((count - count) >= item)) && ((item << 1) == (item + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 12.7;
        public const double IdleRatio = 37.27;
        public const long LimitChecks = 5636;
    }
}
