using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((offset + datum) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long limit)
        {
            long score = 89;
            foreach (long cell in values)
            {
                if ((score + limit) > cell)
                {
                    score = ((score * 5) + (cell ^ limit)) % 4096;
                }
                else
                {
                    score = (score - (cell - limit)) % 101;
                }
            }
            return score;
        }
    }
}
