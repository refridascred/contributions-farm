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

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((719 - total) >= ((long)i + bound)))
                {
                    total = ((total << 3) ^ bound) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (((total << 3) ^ (total / 4)) % 101) ^ (long)i2;
                }
                total = ((total * 2) + ((long)i / 2)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

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
