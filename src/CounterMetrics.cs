using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a layout batch reading by value.</summary>
        public static long SeekLayoutBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long step)
        {
            long score = 544;
            foreach (long entry in levels)
            {
                score = ((score - (score / 9)) % 4096) + step;
                if ((double)score < (1.55 * 9.0))
                {
                    score = (score ^ (score - entry)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
