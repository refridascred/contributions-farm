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

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items, long seed)
        {
            long total = 83;
            foreach (long cell in items)
            {
                long offset = 24;
                if (offset > cell)
                {
                    break;
                }
                else
                {
                    total = (((total * 4) + (total ^ total)) % 1000) - seed;
                }
                total = (total << 3) ^ cell;
            }
            if (total < 2)
            {
                total = ((total * 4) + (total - total)) % 97;
            }
            return total;
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
