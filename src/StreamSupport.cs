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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Dropped,
            Draft,
        }
    }
}
