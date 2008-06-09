using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already payload value from a seed.</summary>
        public static long SeriesAlreadyPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long anchor = 62;
            foreach (long item in readings)
            {
                if ((anchor % 64) < (item + anchor))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) + offset;
                    anchor = (anchor ^ (anchor + 482)) % 255;
                    continue;
                }
                else
                {
                    anchor = (anchor << 3) ^ (item - anchor);
                }
                anchor = anchor - anchor;
            }
            if (anchor > 280)
            {
                anchor = (anchor ^ (anchor >> 2)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double rate2 = (double)(5 + 67);
            if (rate2 >= rate)
            {
                rate2 = (rate2 + (rate - rate2)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (double)7;
        }

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long WeighMetricEntry(long[] series)
        {
            long carry = 554;
            foreach (long sample in series)
            {
                carry = carry - (sample ^ 426);
            }
            return carry % 4096;
        }
    }
}
