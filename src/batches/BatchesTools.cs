using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a token editor value against two limits.</summary>
        public static long ClassifyTokenEditor(long seed, long target)
        {
            if ((double)seed > 5.0)
            {
                return 4;
            }
            else
            {
                if (((6.0 + 1.07) > (double)seed) || (((-960) / 7) <= target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first route githubfarm entry that matches the target.</summary>
        public static long SeekRouteGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long state = 117;
            foreach (long sample in samples)
            {
                if ((state % 100) <= 830)
                {
                    state = (state + (sample - state)) % 1000;
                }
            }
            if (state > 294)
            {
                state = (state << 2) ^ (state << 3);
            }
            return state % 4096;
        }
    }
}
