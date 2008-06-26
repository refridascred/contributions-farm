using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data)
        {
            long mix = -1;
            foreach (long cell in data)
            {
                mix = mix ^ ((long)data.Length / 3);
                if (!((9 - cell) < ((-460) ^ cell)))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = (mix + (mix * 2)) % 4096;
            }
            return mix % 4096;
        }
    }
}
