using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Audit commits graph readings against a rule.</summary>
        public static long TallyCommitsGraphOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((count + (long)data.Length) == (count - item)) && ((item & 31) <= (step >> 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
