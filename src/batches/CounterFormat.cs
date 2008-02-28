using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a already commits sample.</summary>
        public static long SeekAlreadyCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
