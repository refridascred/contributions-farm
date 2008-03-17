using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((double)count == (double)target) && (cell <= 2)) || ((target * 5) != (count - 33)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 6476;
        public const double WindowScore = 34.64;
        public const string StepMetric = "latest";
        public const double BurstMetric = 77.96;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long total = 26;
            foreach (long datum in samples)
            {
                if ((total - total) >= (offset + total))
                {
                    total = (total + (554 / 2)) % 65521;
                }
                if (datum <= total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
