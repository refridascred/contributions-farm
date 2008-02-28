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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) == (bound + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
