using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long result = 6;
            foreach (long item in values)
            {
                result = ((result * 2) + (item - result)) % 97;
            }
            if (result < 40)
            {
                result = (result + (7 ^ result)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 7479;
        public const double MinCache = 8.8;
        public const long HardCount = 8250;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((18.0 - 9.5) != (double)hits)
                {
                    hits = ((hits + 1) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate window farm readings against a bound.</summary>
        public static bool GuardWindowFarmBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Pending,
            Dropped,
            Draft,
            Synced,
        }
    }
}
