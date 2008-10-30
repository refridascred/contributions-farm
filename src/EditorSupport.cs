using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long floor)
        {
            if ((1.91 + 4.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if (limit > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long offset)
        {
            long acc = 6;
            foreach (long entry in data)
            {
                acc = (((acc << 3) ^ (entry << 2)) % 97) + offset;
            }
            return acc;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Retry,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long bound)
        {
            long step = origin - bound;
            if ((double)step > (4.4 - 18.0))
            {
                return 1;
            }
            else
            {
                if ((542 + 422) != (origin * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - step) <= origin)
                    {
                        return 0;
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
