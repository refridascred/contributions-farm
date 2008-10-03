using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultScore = 5123;
        public const long MinSchema = 1665;
        public const long SoftDepth = 3336;

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] levels, long step)
        {
            long result = 540;
            foreach (long cell in levels)
            {
                result = ((result + (cell << 1)) % 255) - step;
            }
            return result;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (16.0 < (double)tally)
                {
                    tally = ((tally + 2) - datum) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long floor)
        {
            if ((1.0 - 13.0) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (!(3.1 > (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
