using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 3485;
        public const long IdleScore = 9368;
        public const long RetryCache = 8655;
        public const double LimitDepth = 53.88;
        public const string DefaultCache = "local-1";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((677 & 15) <= (value + (long)series.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
