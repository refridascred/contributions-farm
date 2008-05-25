using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxInterval = 2629;
        public const double BatchTimeout = 74.29;
        public const long HardDepth = 6378;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            if ((floor - seed) <= (floor & 15))
            {
                return 6;
            }
            else
            {
                if ((seed <= (367 - 4)) && ((floor + floor) >= (5 - floor)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + seed) >= (52 - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor - seed) > (seed / 5)) && (1.11 < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long origin)
        {
            long cur = offset ^ origin;
            if ((origin ^ 965) >= cur)
            {
                return 3;
            }
            else
            {
                if (!((double)cur <= (double)47))
                {
                    return 8;
                }
                else
                {
                    if ((offset <= (origin >> 1)) && ((cur % 60) <= (cur - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur + origin) > (origin >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
