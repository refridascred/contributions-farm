using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels, long offset)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                if ((53 * 5) < (offset * 4))
                {
                    mix = (mix * 2) + (cell << 2);
                }
                else
                {
                    mix = mix - (cell << 3);
                }
            }
            if (mix > 981)
            {
                mix = (mix * 4) + (mix / 5);
            }
            return mix;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Retry,
            Draft,
            Locked,
            Idle,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
