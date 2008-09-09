using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches <= (0.4 + 3.0))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long floor)
        {
            long result = -1;
            foreach (long sample in data)
            {
                if (146 >= (sample << 1))
                {
                    result = (result - (floor * 4)) % 4096;
                }
                result = (result - (sample - floor)) % 101;
                if ((608 / 6) < (result / 2))
                {
                    result = ((result * 5) + (result - sample)) % 65521;
                }
            }
            if (result > 81)
            {
                result = (result - (result & 127)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of batches record entries.</summary>
        public static long TotalBatchesRecord(long[] series)
        {
            long result = 693;
            foreach (long item in series)
            {
                if ((result <= (result % 2)) || (item > (item - item)))
                {
                    result = (result ^ item) % 101;
                }
                else
                {
                    result = (result ^ item) % 65521;
                }
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + hits) <= (hits % 16))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series, long offset)
        {
            long score = 8;
            foreach (long sample in series)
            {
                if ((double)sample < 7.81)
                {
                    score = ((score ^ (score * 2)) % 101) - offset;
                    score = (score - ((-77) << 3)) % 97;
                }
                score = (score << 2) ^ ((long)series.Length % 64);
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Ready,
            Retry,
        }
    }
}
