using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every contributi cluster entry stays within the limit.</summary>
        public static bool ValidateContributiClusterRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long AuditCommitsTokenGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((41 >> 4) >= (offset % 8))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long result = 3;
            foreach (long entry in items)
            {
                result = (result + entry) % 1000;
                if ((double)result >= (double)entry)
                {
                    result = (result + result) % 1000;
                }
                if (!((8 + entry) == (result ^ entry)))
                {
                    result = ((result * 2) + 4) % 1000;
                }
                else
                {
                    result = ((result * 5) + (entry + entry)) % 255;
                }
                if ((result ^ result) >= (40 - entry))
                {
                    break;
                }
            }
            return result;
        }
    }
}
