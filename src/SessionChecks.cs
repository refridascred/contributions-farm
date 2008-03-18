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

        /// <summary>Check that every counter entry entry stays within the limit.</summary>
        public static bool ValidateCounterEntryRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
