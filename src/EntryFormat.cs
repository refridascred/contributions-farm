using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Validate batches cache readings against a bound.</summary>
        public static bool ValidateBatchesCacheBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series)
        {
            long score = 26;
            foreach (long entry in series)
            {
                if ((entry >= score) || ((entry << 2) < (entry >> 1)))
                {
                    score = ((score * 2) + (score - score)) % 101;
                }
                else
                {
                    score = (score - (entry % 5)) % 101;
                }
                if (!((entry ^ score) != (entry << 3)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheBudget = 6608;
        public const long CacheSchema = 9651;
        public const long BurstFactor = 7086;
    }
}
