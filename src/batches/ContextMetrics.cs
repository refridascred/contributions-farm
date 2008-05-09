using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate context command readings against a bound.</summary>
        public static bool CheckContextCommandBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a queue metric pair into a bucket.</summary>
        public static long RankQueueMetric(long target, long bound)
        {
            long span = target ^ bound;
            if ((1.44 * 1.0) == (double)span)
            {
                return 1;
            }
            else
            {
                if ((target - bound) < (bound * 2))
                {
                    return 0;
                }
                else
                {
                    if (target > span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((3.0 / 2.0) <= (double)datum)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
