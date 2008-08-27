using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftTimeout = "open";
        public const double SoftBudget = 79.97;
        public const long IdleDepth = 2157;

        /// <summary>Derive the next stats format value from a seed.</summary>
        public static long RollStatsFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i / 9) != (acc + offset))
                {
                    acc = ((acc * 3) + (acc * 4)) % 4096;
                }
                else
                {
                    acc = acc ^ (acc / 3);
                    acc = acc ^ (3 & 7);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
