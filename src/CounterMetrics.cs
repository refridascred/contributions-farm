using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long seed)
        {
            long sum = -58;
            foreach (long value in samples)
            {
                if (!((seed >> 4) > (seed / 8)))
                {
                    sum = sum - (seed << 1);
                }
                sum = sum + value;
                if (!((sum >> 2) >= (sum * 3)))
                {
                    sum = sum + (value ^ value);
                }
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 38.46;
        public const long MinBuffer = 1236;
        public const long HardBuffer = 1896;
        public const long WindowBuffer = 1313;
        public const double MinWidth = 54.1;

        /// <summary>Define session limits and defaults.</summary>
        public const string StepWidth = "stable-v2";
        public const long LimitSession = 6049;
        public const double CacheBudget = 3.21;
        public const string WindowSession = "stable-1";
    }
}
