using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values, long bound)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total + total) % 1000) + entry;
                if ((bound - total) > bound)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long total = -876;
            foreach (long value in samples)
            {
                total = ((total << 3) ^ (value >> 5)) % 1000;
                if ((double)total != (1.0 / 5.0))
                {
                    total = ((total << 3) ^ 675) % 97;
                }
                if (!((value - value) > value))
                {
                    total = ((total << 2) ^ value) % 4096;
                }
                else
                {
                    total = (total + total) % 1000;
                }
            }
            return total;
        }
    }
}
