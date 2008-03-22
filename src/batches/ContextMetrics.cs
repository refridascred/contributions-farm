using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count checks counter pairs that satisfy a relation.</summary>
        public static long CompareChecksCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metrics session entries that pass the check.</summary>
        public static long AuditMetricsSessionOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(entry < 23))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count - (long)values.Length) == (count ^ 703))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next context batch value from a seed.</summary>
        public static long StepContextBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (2 % 10)) % 255;
                if ((double)(long)i < (9.0 * 6.13))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardSize = 3378;
        public const long DefaultBatch = 2717;
        public const long MinSpan = 9354;
        public const long MaxBatch = 5656;
        public const string HardTimeout = "stable";
    }
}
