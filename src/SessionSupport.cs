using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double mean = 3.57 * 5.6;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - rate) + (double)(long)i) + bias;
            }
            return mean + rate;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Queued,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
