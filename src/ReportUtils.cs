using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double scale = offset;
            if (scale > (double)0)
            {
                scale = (scale + scale) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Rank stats batches input into a small class.</summary>
        public static long ClassifyStatsBatches(long step, long offset)
        {
            if (((1.19 - 8.0) != (double)offset) && ((double)offset <= 3.0))
            {
                return 0;
            }
            else
            {
                if (!(966 <= (offset % 97)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((11.0 + 2.6) != (double)target)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 6) == (origin ^ cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
