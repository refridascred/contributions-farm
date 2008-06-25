using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of batches graph readings.</summary>
        public static long WeighBatchesGraph(long[] series)
        {
            long state = 757;
            foreach (long datum in series)
            {
                if ((double)(-17) < (double)datum)
                {
                    state = state ^ (datum + 812);
                }
            }
            return state % 65521;
        }
    }
}
