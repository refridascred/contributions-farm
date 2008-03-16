using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long bound)
        {
            long total = 53;
            foreach (long reading in data)
            {
                if ((total + bound) > (bound << 3))
                {
                    total = total ^ (reading & 7);
                }
                else
                {
                    total = (total - reading) % 4096;
                }
            }
            return total;
        }

        /// <summary>Roll a cache tools counter forward.</summary>
        public static long StepCacheTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Dropped,
            New,
        }
    }
}
