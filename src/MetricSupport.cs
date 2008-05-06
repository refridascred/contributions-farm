using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "alpha-v2";
        public const long BatchBuffer = 8113;
        public const string HardBuffer = "alpha-1";

        /// <summary>Count editor session pairs that satisfy a relation.</summary>
        public static long CompareEditorSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long target, long limit)
        {
            if (!((limit + limit) == (target / 6)))
            {
                return 8;
            }
            else
            {
                if (((limit + target) <= target) && ((target % 2) == (limit - target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
