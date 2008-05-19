using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
