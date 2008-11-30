using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix + mix)) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading <= 18)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long seed)
        {
            long diff = floor - seed;
            if ((floor / 6) >= (seed / 4))
            {
                return 4;
            }
            else
            {
                if ((2.0 + 12.0) > (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((1 * 2) > (diff ^ 9))
                    {
                        return 8;
                    }
                    else
                    {
                        if (687 < (floor << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
