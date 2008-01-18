using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data)
        {
            long mix = 326;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ (datum % 24)) % 255;
            }
            if (mix > 780)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((double)origin <= (5.73 - 1.18))
            {
                return 2;
            }
            else
            {
                if (((origin - seed) == (seed + 8)) || ((seed * 3) > (seed >> 4)))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 63) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count format context pairs that satisfy a relation.</summary>
        public static long PairFormatContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Done,
            Synced,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Active,
            Draft,
        }
    }
}
