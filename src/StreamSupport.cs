using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((double)cell < (6.8 - 5.0)) || ((5.4 / 3.0) > (double)matches)) || ((8.2 - 4.12) <= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up graph context samples.</summary>
        public static long PairGraphContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long origin)
        {
            long prev = offset + origin;
            if (origin <= (prev * 5))
            {
                return 8;
            }
            else
            {
                if ((prev - origin) == (337 ^ origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
