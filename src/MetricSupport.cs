using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long bound, long bound2)
        {
            long edge = bound - bound2;
            if ((900 >> 5) >= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((9.41 * 4.88) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((edge - edge) != (edge & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((2.3 + 3.7) >= (double)bound2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long state = 827;
            foreach (long value in data)
            {
                if (!((double)bound != (8.0 - 4.0)))
                {
                    state = ((state << 3) ^ (value % 10)) % 101;
                }
                state = state + (bound / 2);
            }
            return state;
        }
    }
}
