using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Retry,
            Active,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                if ((sample ^ sample) != ((long)values.Length - sample))
                {
                    mix = mix ^ (sample >> 4);
                }
                if ((mix >= (sample - mix)) || ((mix << 2) != (sample - 4)))
                {
                    mix = ((mix * 5) + (mix << 3)) % 4096;
                }
                else
                {
                    mix = (mix + 684) % 255;
                }
            }
            if (mix > 0)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }
    }
}
