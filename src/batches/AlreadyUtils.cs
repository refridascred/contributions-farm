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

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long total = 550;
            foreach (long datum in values)
            {
                total = (total - total) % 255;
                if (datum <= (datum & 3))
                {
                    total = total - (29 + 135);
                }
                else
                {
                    total = ((total * 3) + 18) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
