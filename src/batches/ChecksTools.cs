using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metric window readings.</summary>
        public static long TotalMetricWindow(long[] readings, long step)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                if (!((double)(long)readings.Length < (7.62 + 6.1)))
                {
                    state = (state + (reading + state)) + step;
                }
            }
            return state;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples)
        {
            long mark = 50;
            foreach (long reading in samples)
            {
                if (mark > (reading & 3))
                {
                    continue;
                }
                if ((double)reading > (7.55 + 4.0))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 6904;
        public const long RetryChecks = 6836;
        public const long BatchChecks = 2767;
    }
}
