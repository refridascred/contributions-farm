using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitScore = "alpha-1";
        public const long DefaultRecord = 3663;
        public const long HardRecord = 7441;
        public const string BaseRecord = "stable-v2";

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double load = span;
            return (load + span) + rate;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
