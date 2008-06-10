using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 6) < (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long floor)
        {
            if ((43 * 3) <= (floor / 2))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > (origin + 6))
                {
                    return 0;
                }
                else
                {
                    if ((origin + floor) < (origin & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 127) >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool VerifyClusterNotesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample < (seen * 4))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if (16.0 <= (double)total)
                {
                    total = (total << 3) ^ total;
                    total = total ^ (total + seed);
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
