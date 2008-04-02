using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many counter metrics samples are out of range.</summary>
        public static long TallyCounterMetricsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits < (1.31 + 8.0))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
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
