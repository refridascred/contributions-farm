using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((target + target) != (count << 2))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Classify a route window pair into a bucket.</summary>
        public static long RankRouteWindow(long limit, long offset)
        {
            if ((limit < (offset + limit)) && ((double)limit > (2.36 * 20.0)))
            {
                return 8;
            }
            else
            {
                if (0.8 >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((18 * 3) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long WeighEntryBatch(long[] series, long target)
        {
            long score = 90;
            foreach (long sample in series)
            {
                if (5.4 >= (double)sample)
                {
                    score = ((score - score) % 101) - target;
                }
            }
            if (score < 459)
            {
                score = (score * 3) + (score / 8);
            }
            return score;
        }
    }
}
