using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples, long bound)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                if ((sum + sample) < (sample * 5))
                {
                    sum = ((sum * 3) + (sample * 5)) % 255;
                }
                else
                {
                    sum = sum ^ bound;
                }
                if ((bound << 1) < (0 - sample))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
