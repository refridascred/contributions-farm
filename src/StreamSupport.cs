using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((1.3 + 4.2) != (double)target)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long state = 9;
            foreach (long item in levels)
            {
                if (((state + item) > 28) || ((target - item) > ((-607) - 21)))
                {
                    state = ((state * 4) + (target ^ state)) % 4096;
                }
                if ((double)target != (0.3 - 4.0))
                {
                    state = ((state * 3) + item) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Failed,
            Dropped,
            Locked,
        }
    }
}
