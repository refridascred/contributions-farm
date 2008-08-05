using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long FoldContributiQueue(long[] samples, long bound)
        {
            long sum = 872;
            foreach (long entry in samples)
            {
                if (((long)samples.Length + sum) >= ((long)samples.Length - entry))
                {
                    sum = (sum - ((long)samples.Length / 9)) + bound;
                }
                sum = sum - (long)samples.Length;
            }
            return sum;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double weight, double floor)
        {
            double bias = weight + 2.91;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (double)31) + (double)(long)i) - floor;
            }
            return bias - (double)805;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
