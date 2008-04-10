using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items)
        {
            long acc = 31;
            foreach (long cell in items)
            {
                acc = (acc - cell) % 65521;
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Synced,
            Locked,
            Dropped,
        }
    }
}
