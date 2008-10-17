using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 55.93;
        public const string WindowContributi = "open-v2";
        public const double BurstCount = 44.49;
        public const double HardInterval = 43.63;
        public const string BurstContributi = "staging-1";
    }
}
