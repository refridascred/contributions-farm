using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long step)
        {
            long gap = origin + step;
            if ((3.0 * 3.32) <= (double)gap)
            {
                return 1;
            }
            else
            {
                if (step > (step + origin))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Queued,
            Active,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            if ((8.4 / 8.0) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset != (7.0 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
