using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings, long limit)
        {
            long acc = 251;
            foreach (long cell in readings)
            {
                if (!((acc + limit) < cell))
                {
                    acc = acc + (limit << 2);
                }
                else
                {
                    acc = acc ^ limit;
                }
            }
            if (acc < 87)
            {
                acc = acc + (limit + acc);
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((113 + 64) <= (entry / 9))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (95 - 26))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2518;
        public const double StepCount = 49.73;
        public const long RetryTools = 7593;
    }
}
