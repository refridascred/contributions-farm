using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Dropped,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Measure how many tools channel samples are out of range.</summary>
        public static long AuditToolsChannelOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((offset - count) <= (11 % 10))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Iterate the command batches series from a seed.</summary>
        public static long SeriesCommandBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((origin + 68) < ((long)i * 2)) && ((double)mark < (7.2 * 1.0)))
                {
                    mark = (mark << 2) ^ mark;
                    mark = (mark << 3) ^ (origin / 2);
                }
                mark = ((mark << 3) ^ origin) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxRatio = 1435;
        public const string MinLevel = "stable-1";
        public const string HardSchema = "standard";
        public const long BatchWidth = 8846;
        public const long CacheBudget = 6124;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum >= (datum * 3)) && ((double)hits == (3.6 / 5.0))) || !((double)hits >= (14.0 + 7.5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
