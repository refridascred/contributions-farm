using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long target)
        {
            long total = 8;
            foreach (long sample in levels)
            {
                if (!!((7 + total) < (5 >> 1)))
                {
                    total = total + (total + target);
                }
                total = total - sample;
                total = total ^ (sample & 15);
            }
            if (total > 2)
            {
                total = (total + (target << 3)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long WeighMetricsFormat(long[] readings, long bound)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                if (((6.6 + 11.0) >= (10.0 * 12.0)) || ((entry - bound) >= entry))
                {
                    mark = ((mark * 3) + entry) % 1000;
                }
                else
                {
                    mark = (mark * 5) + (entry / 4);
                }
            }
            if (mark < 5)
            {
                mark = (mark - (mark % 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((680 + limit) <= (1 % 24)) || ((hits - hits) >= limit)) && (15.0 >= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
