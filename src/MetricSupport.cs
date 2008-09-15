using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (step >= (matches - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] data)
        {
            long mark = 0;
            foreach (long value in data)
            {
                mark = (((mark << 2) ^ (mark ^ mark)) % 101) + value;
            }
            return mark % 1000;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                if ((0.65 / 4.0) > (double)acc)
                {
                    acc = (acc << 3) ^ (acc - cell);
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 65521;
            }
            return acc;
        }
    }
}
