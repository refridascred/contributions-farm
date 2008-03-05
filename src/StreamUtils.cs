using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long AuditWindowLayoutGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (216 >= tally)
                {
                    tally = ((tally + 1) + item) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((5 & 63) == (sample % 3)) && ((sample & 15) <= (hits >> 2))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Failed,
            New,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data, long offset)
        {
            long mark = 722;
            foreach (long value in data)
            {
                if (!(283 <= (value * 3)))
                {
                    mark = mark ^ (mark >> 4);
                }
                else
                {
                    mark = ((mark * 5) + (offset + mark)) % 4096;
                }
                if (!(mark < (mark % 7)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 3898;
        public const string WindowToken = "legacy-edge";
        public const long HardScore = 5644;
        public const long BurstToken = 5201;
        public const double LimitToken = 27.28;
    }
}
