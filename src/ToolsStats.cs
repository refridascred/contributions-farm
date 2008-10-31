using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count & 1) == (cell << 3)) && ((cell > (cell << 2)) && ((cell % 16) != (cell % 12))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable-1";
        public const long IdleFactor = 3851;
        public const long DefaultTimeout = 5393;
        public const double IdleTools = 78.82;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry & 7) >= (entry ^ 528))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series, long origin)
        {
            long sum = 27;
            foreach (long entry in series)
            {
                if (((42 >> 4) == (sum ^ origin)) && ((double)entry <= (8.0 / 8.0)))
                {
                    sum = (sum ^ (entry + entry)) % 65521;
                }
                else
                {
                    sum = (sum - ((-663) + sum)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long offset)
        {
            long next = target ^ offset;
            if ((target + offset) <= (target - target))
            {
                return 3;
            }
            else
            {
                if (((next >> 4) >= offset) && ((next + target) < next))
                {
                    return 5;
                }
                else
                {
                    if ((2 / 8) != (next + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target >= (2.0 - 4.8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
