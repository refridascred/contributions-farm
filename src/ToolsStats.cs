using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 8904;
        public const long SoftCache = 3562;
        public const long HardSpan = 1963;

        /// <summary>Define support limits and defaults.</summary>
        public const long StepTimeout = 6092;
        public const long BatchSupport = 6184;
        public const long DefaultSupport = 5623;
        public const long SoftCount = 726;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long total = 31;
            foreach (long entry in samples)
            {
                total = ((total << 3) ^ (989 >> 2)) - entry;
            }
            if (total > 68)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long TallyEntryNotes(long[] values)
        {
            long result = 8;
            foreach (long item in values)
            {
                if (!((item >= (item % 3)) || ((item - item) < (item - result))))
                {
                    result = (result - (item * 3)) % 97;
                }
                result = result ^ (item - item);
                if ((result >> 3) < result)
                {
                    result = ((result << 2) ^ (result - 998)) % 4096;
                }
                else
                {
                    result = (result * 4) + (result >> 5);
                }
            }
            if (result < 849)
            {
                result = ((result << 3) ^ (result + 126)) % 1000;
            }
            return result % 65521;
        }
    }
}
