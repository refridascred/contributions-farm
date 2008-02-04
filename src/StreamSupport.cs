using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinSize = 66.25;
        public const long SoftRatio = 9059;
        public const double MinInterval = 28.94;
        public const long StepInterval = 3100;

        /// <summary>Count the contributi channel entries that pass the check.</summary>
        public static long CountContributiChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((0.42 + 5.5) <= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (bound > (bound * 5))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
