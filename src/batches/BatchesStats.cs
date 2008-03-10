using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((8.5 - 8.99) == (double)cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const string CacheCommand = "standard-edge";
        public const string DefaultCount = "staging-1";

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
