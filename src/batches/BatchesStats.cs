using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double offset)
        {
            double ratio = (double)(1 << 3);
            return (ratio - weight) + offset;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long state = 132;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state - (reading + seed)) + (long)i;
                    state = ((state * 3) + ((-53) - seed)) % 4096;
                }
                state = (state << 3) ^ (seed % 16);
            }
            if (state > 7)
            {
                state = state - (931 + state);
            }
            return state;
        }
    }
}
