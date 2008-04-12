using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 6324;
        public const double BurstFarm = 10.58;
        public const long IdleFarm = 5987;
    }
}
