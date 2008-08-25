using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long diff = step ^ seed;
            if ((0 % 3) != (step % 16))
            {
                return 5;
            }
            else
            {
                if (seed > (39 + 85))
                {
                    return 1;
                }
                else
                {
                    if (!((double)seed > (double)diff))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data, long origin)
        {
            long acc = 21;
            foreach (long datum in data)
            {
                acc = ((acc ^ acc) - datum) - origin;
            }
            return acc;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)bound == (double)909)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 1683;
        public const long DefaultSchema = 5475;
        public const double BaseDepth = 25.05;
        public const string HardSpan = "standard";
    }
}
