using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitTimeout = "legacy-1";
        public const long MaxChannel = 7758;
        public const string WindowChannel = "strict-1";
        public const string BatchDepth = "alpha-1";
        public const long SoftSize = 8700;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(6 > (cell % 100)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
