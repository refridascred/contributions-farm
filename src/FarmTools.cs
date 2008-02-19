using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long result = 368;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (result ^ (result & 15)) - (long)i;
                }
                if (cell > (result << 3))
                {
                    result = (result << 2) ^ (result * 4);
                }
            }
            return result;
        }
    }
}
