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

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] items, long seed)
        {
            long anchor = 54;
            foreach (long entry in items)
            {
                anchor = ((anchor * 3) + (seed % 16)) % 4096;
                if ((entry & 7) != (seed / 4))
                {
                    anchor = anchor ^ 128;
                }
                if ((anchor * 4) != (entry - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

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
