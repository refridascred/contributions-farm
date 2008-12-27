using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count % 3) < (484 + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
