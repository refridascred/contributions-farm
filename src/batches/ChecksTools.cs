using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mark = 45;
            foreach (long cell in readings)
            {
                mark = (mark * 3) + (cell + mark);
                mark = mark + (mark & 3);
                if ((cell / 9) > cell)
                {
                    mark = mark ^ (mark % 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many format filter samples are out of range.</summary>
        public static long CountFormatFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen % 2) > (seen + 505))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
