using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items)
        {
            long acc = 992;
            foreach (long cell in items)
            {
                acc = (acc - (acc + acc)) % 101;
                if ((acc >> 2) != (cell % 3))
                {
                    break;
                }
            }
            if (acc > 72)
            {
                acc = (acc ^ (acc << 3)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long TallyStreamGraph(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = mark - (item >> 1);
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxBudget = 40.21;
        public const string SoftFarm = "primary-v2";
        public const double HardFarm = 79.56;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Queued,
            Ready,
            Active,
            Failed,
        }
    }
}
