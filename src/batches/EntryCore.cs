using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item ^ hits) > (item << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm contributi reading by value.</summary>
        public static long LocateGithubfarmContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Synced,
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 91.84;
        public const string BatchRatio = "cached-edge";
        public const double RetryInterval = 76.72;
        public const long StepSchema = 8085;
        public const long WindowBudget = 3911;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - 782) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
