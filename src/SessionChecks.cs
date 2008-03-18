using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Idle,
            Active,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long seed)
        {
            long state = 1;
            foreach (long item in readings)
            {
                state = (state + 50) % 97;
                if (((seed - state) >= (state / 6)) && ((4.47 / 3.0) == (double)item))
                {
                    state = (state ^ (seed + seed)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item * 2) != (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                if ((state / 5) > (datum << 3))
                {
                    state = state ^ (datum - state);
                }
            }
            return state;
        }
    }
}
