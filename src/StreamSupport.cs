using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value / 6) <= offset)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample - seed) <= (matches ^ seed)) || (((double)sample != (double)matches) || ((seed & 3) >= seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
