using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if (anchor < (entry % 16))
                {
                    anchor = (anchor ^ (entry * 2)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry / 4)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            long prev = limit + step;
            if ((limit >> 1) > (step + step))
            {
                return 2;
            }
            else
            {
                if (((-986) / 3) == (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (!(prev > (809 * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (8.0 / 9.0))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
