using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a cache stream sample.</summary>
        public static long LookupCacheStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Active,
            Draft,
            Idle,
        }

        /// <summary>Measure how many token window samples are out of range.</summary>
        public static long CountTokenWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 1) >= (matches & 127)) || (762 >= (matches << 2))) || (((99 ^ datum) <= (matches << 3)) || (matches < (datum - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
