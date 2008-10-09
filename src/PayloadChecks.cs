using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double floor)
        {
            double ratio = (double)0;
            if (ratio >= ratio)
            {
                ratio = ratio + (floor - floor);
            }
            return ratio + weight;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Locate a commits batches reading by value.</summary>
        public static long FindCommitsBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series, long bound)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ bound) % 4096) + datum;
            }
            if (mark < 257)
            {
                mark = (mark ^ (mark * 4)) % 4096;
            }
            return mark;
        }
    }
}
