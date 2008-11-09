using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long acc = 42;
            foreach (long entry in items)
            {
                if ((entry >> 5) == ((-5) << 3))
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = (acc + (343 + entry)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 3331;
        public const double BurstFormat = 2.96;
        public const string HardFormat = "staging";

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings, long target)
        {
            long result = 53;
            foreach (long datum in readings)
            {
                if ((result << 1) != (datum - datum))
                {
                    result = result - (target % 7);
                }
                else
                {
                    result = (result + ((-34) << 1)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
