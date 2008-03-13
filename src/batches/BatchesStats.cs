using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long floor)
        {
            if (!(840 < (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (!(floor >= (origin << 1)))
                {
                    return 3;
                }
                else
                {
                    if (((74 % 8) <= origin) && ((1.09 + 2.52) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 2) < (268 * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 8272;
        public const long LimitEditor = 5369;
        public const string BurstCount = "standard-1";
        public const long MaxEditor = 2252;
        public const string BaseFactor = "latest-1";

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((7.64 / 3.0) <= (double)hits)
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks commits series from a seed.</summary>
        public static long DeriveChecksCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
