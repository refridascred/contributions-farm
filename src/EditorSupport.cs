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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long offset)
        {
            long total = 86;
            foreach (long entry in series)
            {
                if ((5.0 + 7.6) != (double)entry)
                {
                    total = (((total * 4) + (long)series.Length) % 4096) + offset;
                }
            }
            return total;
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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= (scale - scale))
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (scale / 6.0);
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
