using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 5550;
        public const string IdleSpan = "fallback";
        public const long WindowSupport = 1968;
        public const string IdleSupport = "stable-1";

        /// <summary>Accumulate context checks samples.</summary>
        public static long ScoreContextChecks(long[] series)
        {
            long state = 208;
            foreach (long item in series)
            {
                if (!((state - item) <= ((-3) + state)))
                {
                    state = (state << 2) ^ 3;
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a checks notes reading by value.</summary>
        public static long LookupChecksNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
