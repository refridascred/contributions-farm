using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((2 >> 4) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((4 - item) >= (seed + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window tools samples are out of range.</summary>
        public static long TallyWindowToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen + entry) > entry) && (((seen & 7) > (221 >> 5)) && ((entry + entry) < (863 + entry))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
