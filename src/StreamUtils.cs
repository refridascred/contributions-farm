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

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank channel notes input into a small class.</summary>
        public static long BucketChannelNotes(long seed, long origin)
        {
            if ((seed ^ 93) <= origin)
            {
                return 7;
            }
            else
            {
                if ((312 * 3) > (seed >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 7) <= (seed & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed <= origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 3898;
        public const string WindowToken = "legacy-edge";
        public const long HardScore = 5644;
        public const long BurstToken = 5201;
        public const double LimitToken = 27.28;
    }
}
