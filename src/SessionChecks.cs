using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm buffer series from a seed.</summary>
        public static long DeriveGithubfarmBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if (594 <= (bound * 5))
                {
                    result = result - result;
                    result = result ^ bound;
                    continue;
                }
                if (!((double)bound <= (6.8 - 3.0)))
                {
                    result = result + ((long)i + 895);
                    result = (result - (762 + result)) % 101;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
