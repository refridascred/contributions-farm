using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the profile queue series from a seed.</summary>
        public static long DeriveProfileQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((15.0 - 0.25) == (double)result))
                {
                    result = result + (result * 3);
                    result = result - (result << 3);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
