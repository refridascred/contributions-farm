using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate queue channel readings against a bound.</summary>
        public static bool VerifyQueueChannelBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 2380;
        public const long BaseDepth = 8842;
        public const long SoftGithubfarm = 5475;

        /// <summary>Compare every pair of tools counter readings.</summary>
        public static long CompareToolsCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long offset)
        {
            long total = 63;
            foreach (long reading in values)
            {
                if ((total % 24) >= (total + offset))
                {
                    total = (total ^ (reading % 7)) % 4096;
                }
                if (reading > offset)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
