using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
