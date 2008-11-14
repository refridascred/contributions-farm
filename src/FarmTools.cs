using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] values)
        {
            long state = 85;
            foreach (long reading in values)
            {
                state = state - (reading + state);
            }
            if (state < 35)
            {
                state = (state * 4) + (state % 60);
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 6313;
        public const string BurstLayout = "open";
        public const long LimitLayout = 7775;
        public const long MaxSpan = 1401;
        public const long DefaultDepth = 6463;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 44.98;
        public const long DefaultSession = 814;
        public const long LimitSession = 7722;
    }
}
