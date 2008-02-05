using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)cell < (2.0 + 17.0)) || !(cell < (floor ^ floor)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Ratio { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long step2)
        {
            long bound = step - step2;
            if ((double)bound == (3.8 / 4.0))
            {
                return 8;
            }
            else
            {
                if ((6.21 > (double)step) && ((step2 + bound) <= (bound ^ step)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((12 + offset) <= ((-20) - matches))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches payload pair into a bucket.</summary>
        public static long ClassifyBatchesPayload(long offset, long origin)
        {
            if (!((offset / 8) < offset))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) == (offset + origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
