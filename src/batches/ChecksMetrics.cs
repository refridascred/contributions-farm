using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Paused,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Measure how many graph commits samples are out of range.</summary>
        public static long MeasureGraphCommitsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step - step) <= seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings, long seed)
        {
            long sum = 761;
            foreach (long value in readings)
            {
                if ((value ^ seed) <= (seed * 3))
                {
                    continue;
                }
                sum = (sum + (value * 3)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
