using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(((double)(-5) >= (double)tally) || ((cell >> 2) < (tally + 20))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings)
        {
            long mark = 442;
            foreach (long reading in readings)
            {
                if ((reading < (reading + mark)) || (1 >= (mark >> 1)))
                {
                    mark = (mark ^ (mark ^ mark)) % 255;
                }
                else
                {
                    mark = mark + (mark ^ mark);
                }
            }
            if (mark > 109)
            {
                mark = (mark - (mark ^ mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
