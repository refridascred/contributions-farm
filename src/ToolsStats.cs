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

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 79.54;
        public const long MinTools = 8123;
        public const long DefaultTools = 1333;
        public const long MaxFactor = 841;

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

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double drift = span;
            if (drift >= (span + gain))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + 1.37;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)(-859)) - (double)(long)i;
            }
            return drift - 9.77;
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
