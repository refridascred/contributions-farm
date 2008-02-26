using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long target)
        {
            if (target <= origin)
            {
                return 3;
            }
            else
            {
                if (origin < (6 * 2))
                {
                    return 6;
                }
                else
                {
                    if ((target + 720) >= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((value >> 4) > (value << 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
