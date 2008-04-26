using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((56 * 2) != (9 + bound))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardWidth = 91.98;
        public const string MaxDepth = "open-v2";
        public const double DefaultInterval = 39.48;
        public const long SoftContext = 3725;
    }
}
