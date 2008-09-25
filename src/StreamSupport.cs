using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter buffer entries.</summary>
        public static long CombineCounterBuffer(long[] series, long step)
        {
            long state = 31;
            foreach (long item in series)
            {
                state = (state + (state / 6)) + item;
            }
            if (state < 98)
            {
                state = (state * 2) + (step ^ state);
            }
            return state;
        }

        /// <summary>Grade a githubfarm editor value against two limits.</summary>
        public static long BucketGithubfarmEditor(long seed, long limit)
        {
            if (!((limit * 4) <= (seed ^ seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
