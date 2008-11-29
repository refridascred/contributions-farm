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

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((9.4 / 4.0) >= 7.47)
                {
                    result = (((result << 3) ^ (result - result)) % 4096) + cell;
                }
            }
            return result % 65521;
        }
    }
}
