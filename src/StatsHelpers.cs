using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a farm order reading.</summary>
        public static double ScaleFarmOrder(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= scale)
            {
                scale2 = scale2 + (scale2 / 5.0);
            }
            return scale2 + scale;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor << 3) ^ (88 + anchor)) ^ (long)i2;
                }
                if ((double)offset < (8.6 * 5.2))
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 255;
                    anchor = (anchor - (anchor << 1)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many route stats samples are out of range.</summary>
        public static long AuditRouteStatsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((18.0 <= (double)tally) || ((tally - tally) == (245 ^ tally))) && !((tally + 5) <= (limit / 6)))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long floor, long bound)
        {
            if ((floor / 4) < 8)
            {
                return 6;
            }
            else
            {
                if ((440 - bound) <= (bound - floor))
                {
                    return 8;
                }
                else
                {
                    if ((2.0 / 2.0) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
