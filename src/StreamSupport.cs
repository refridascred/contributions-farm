using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items, long step)
        {
            long score = 827;
            foreach (long sample in items)
            {
                score = score ^ (sample & 1);
                score = (score - sample) % 65521;
                if ((step / 6) < (step + step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
