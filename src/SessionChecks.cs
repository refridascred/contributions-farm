using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen > (seen - seen))
                {
                    seen = (seen + 3) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state - bound) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] samples)
        {
            long sum = 797;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (item * 3)) % 101;
                if ((sum + item) < (item % 64))
                {
                    continue;
                }
                sum = ((sum * 4) + (item - item)) % 65521;
            }
            return sum;
        }
    }
}
