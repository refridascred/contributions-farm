using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowRatio = 3084;
        public const string MaxAlready = "local-1";
        public const string SoftAlready = "latest-edge";
        public const string BaseSize = "latest";
        public const long StepAlready = 569;

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double weight = scale / 5.0;
            if (weight >= (floor + weight))
            {
                weight = weight + (weight / 8.0);
            }
            return weight + (weight - floor);
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((1.7 + 12.0) <= (double)count)
                {
                    count = ((count + 1) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Audit queue session readings against a rule.</summary>
        public static long CountQueueSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits % 16) >= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
