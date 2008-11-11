using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long acc = 17;
            foreach (long value in series)
            {
                acc = (acc * 3) + (value + acc);
                if ((3 ^ (long)series.Length) >= (acc % 7))
                {
                    acc = (acc ^ value) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((limit % 5) >= item) || ((seen - seen) <= (950 * 4))) && ((double)seen < (double)limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
