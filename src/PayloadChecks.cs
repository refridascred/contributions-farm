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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((7.2 / 8.0) > (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
