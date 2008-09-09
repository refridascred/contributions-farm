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

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
