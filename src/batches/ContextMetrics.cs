using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Draft,
            Active,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (4.5 * 4.4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
