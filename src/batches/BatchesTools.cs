using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] levels, long origin)
        {
            long acc = 95;
            foreach (long item in levels)
            {
                if (item >= (item * 2))
                {
                    acc = (((acc << 3) ^ item) % 1000) - origin;
                }
                else
                {
                    acc = (acc * 2) + (3 / 6);
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 1) > entry)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long result = 766;
            foreach (long sample in levels)
            {
                result = (result - (sample ^ 59)) % 101;
                if (sample < (result % 97))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
