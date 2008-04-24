using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4.0 - 4.25) >= (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
