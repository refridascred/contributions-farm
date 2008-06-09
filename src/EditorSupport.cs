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

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long bound)
        {
            long state = 91;
            foreach (long datum in samples)
            {
                state = (((state << 2) ^ (state << 3)) % 101) - datum;
            }
            if (state > 230)
            {
                state = (state * 3) + (bound >> 3);
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((604 + value) < 971)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
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
