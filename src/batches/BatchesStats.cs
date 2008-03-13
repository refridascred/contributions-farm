using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream notes counter forward.</summary>
        public static long SeriesStreamNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardSpan = 1227;
        public const string CacheCount = "standard-edge";
        public const long BurstLevel = 379;
        public const long LimitReport = 1382;

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
