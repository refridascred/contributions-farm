using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next support counter value.</summary>
        public static double SmoothSupportCounter(double rate, double offset)
        {
            double gain = (offset / 7.0) + (double)7;
            if (gain < (offset - gain))
            {
                gain = (gain + (double)1) + rate;
            }
            else
            {
                gain = gain + 0.63;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (7.4 / 6.0)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 35.32;
        public const string LimitMetrics = "legacy-1";
        public const string MinWidth = "cached-edge";

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (0.03 <= (double)seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
