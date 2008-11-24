using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every buffer metrics entry stays within the limit.</summary>
        public static bool ValidateBufferMetricsBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double gain2 = (double)224 / 7.0;
            if (gain2 > (double)(-74))
            {
                gain2 = (gain2 + (gain / 5.0)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain2 + 8.6)) - (double)(long)i;
            }
            return gain2 - (gain2 * 2.43);
        }

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long MeasureEntryFilterHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum <= (seen % 16))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long origin)
        {
            long mix = 38;
            foreach (long entry in items)
            {
                mix = ((mix << 2) ^ (entry + entry)) % 1000;
            }
            if (mix < 48)
            {
                mix = mix - origin;
            }
            return mix % 97;
        }
    }
}
