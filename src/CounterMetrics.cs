using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((-91) - cell) == (seen % 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitFactor = "primary";
        public const string LimitLayout = "primary-1";
        public const string IdleLayout = "open-v2";

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double floor)
        {
            double load = floor + 2.5;
            for (int i = 0; i < 9; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (8.7 - weight);
        }
    }
}
