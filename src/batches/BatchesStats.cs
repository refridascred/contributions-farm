using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 49.45;
        public const double SoftWidth = 51.88;
        public const double MinCommits = 22.3;
        public const long BatchInterval = 2694;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
