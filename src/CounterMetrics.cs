using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long SeriesSchemaRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (offset - offset)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit report batch readings against a rule.</summary>
        public static long CountReportBatchMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count < 186)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items, long limit)
        {
            long anchor = -876;
            foreach (long cell in items)
            {
                if (!((double)anchor <= (3.0 * 7.19)))
                {
                    anchor = ((anchor - (anchor + 135)) % 1000) - cell;
                }
            }
            if (anchor < 34)
            {
                anchor = (anchor << 2) ^ (limit >> 4);
            }
            return anchor;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
