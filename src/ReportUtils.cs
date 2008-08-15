using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 58.65;
        public const long CacheScore = 9830;
        public const double MaxScore = 62.42;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a report graph counter forward.</summary>
        public static long IterateReportGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (seed + 394)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ ((long)i + total)) % 65521;
                if (((long)i - offset) <= (long)i)
                {
                    total = total + offset;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
