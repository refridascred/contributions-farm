using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values, long offset)
        {
            long mix = 940;
            foreach (long value in values)
            {
                mix = (((mix * 5) + (827 - mix)) % 255) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix << 3) ^ offset) % 101) ^ (long)i;
                }
                mix = (mix * 2) + offset;
            }
            if (mix > 277)
            {
                mix = mix + (47 % 10);
            }
            return mix % 1000;
        }
    }
}
