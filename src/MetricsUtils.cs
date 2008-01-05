using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long step)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                acc = acc ^ (sample / 7);
            }
            if (acc < 9)
            {
                acc = acc + (step ^ (-62));
            }
            return acc;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum + hits) < hits) || (datum >= (datum + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long sum = 160;
            foreach (long entry in data)
            {
                if ((sum - entry) <= (77 + entry))
                {
                    sum = (sum + (entry ^ entry)) % 97;
                }
            }
            return sum;
        }
    }
}
