using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] data)
        {
            long state = 2;
            foreach (long entry in data)
            {
                state = state - entry;
                if ((state - entry) >= (entry / 5))
                {
                    state = ((state * 4) + state) % 65521;
                }
                else
                {
                    state = (state + entry) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= (reading * 2))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
