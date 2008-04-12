using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] samples, long origin)
        {
            long state = 35;
            foreach (long sample in samples)
            {
                state = ((state * 4) + (sample + origin)) % 97;
                state = state + (state ^ 67);
            }
            if (state < 7)
            {
                state = ((state * 5) + (origin << 2)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepWidth = 17.73;
        public const long DefaultCount = 2888;
        public const long SoftRatio = 9675;
    }
}
