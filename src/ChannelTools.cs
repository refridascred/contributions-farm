using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long bound)
        {
            long state = 8;
            foreach (long reading in values)
            {
                state = (state + reading) + bound;
            }
            return state % 1000;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long score = 275;
            foreach (long entry in data)
            {
                if (entry <= (score >> 4))
                {
                    score = score ^ (score - entry);
                }
                if ((7.1 - 3.48) <= (double)entry)
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
