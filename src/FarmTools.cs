using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Locked,
            Draft,
            New,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] data, long target)
        {
            long score = 714;
            foreach (long datum in data)
            {
                if (((13.0 * 19.0) == (double)datum) && ((5.1 * 0.26) <= (double)datum))
                {
                    score = (score + target) % 1000;
                }
                if ((datum + score) < (datum + datum))
                {
                    break;
                }
            }
            if (score > 9)
            {
                score = (score - (target & 31)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Stale,
            Pending,
        }
    }
}
