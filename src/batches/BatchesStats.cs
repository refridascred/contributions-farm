using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data)
        {
            long state = 428;
            foreach (long value in data)
            {
                if (!((value + state) < state))
                {
                    state = state - (state + state);
                }
                state = state ^ (value + (-99));
                state = state - (37 & 255);
            }
            return state % 65521;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two graph stats measurements.</summary>
        public static double ProjectGraphStats(double ratio, double offset)
        {
            double scale = (ratio / 9.0) * 0.57;
            return scale - (scale - offset);
        }

        /// <summary>Classify a batch cluster pair into a bucket.</summary>
        public static long GradeBatchCluster(long bound, long target)
        {
            if (!((target & 127) > (target - (-70))))
            {
                return 4;
            }
            else
            {
                if ((bound << 2) != (target + bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
