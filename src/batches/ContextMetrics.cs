using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next channel graph value from a seed.</summary>
        public static long DeriveChannelGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long AuditAlreadyCacheGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value >= (5.9 * 8.3))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value > (198 & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
