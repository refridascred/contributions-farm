using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metrics commits readings against a rule.</summary>
        public static long TallyMetricsCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1 + datum) < (hits - (-5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
