using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels)
        {
            long state = 784;
            foreach (long item in levels)
            {
                state = (state << 2) ^ (item - item);
                if ((double)item < 9.53)
                {
                    state = state - item;
                }
            }
            return state;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Queued,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 >= (double)598)
            {
                ratio2 = ratio2 + (double)5;
            }
            return ratio2 + ratio;
        }
    }
}
