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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((8.0 + 1.6) >= (double)entry)
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
