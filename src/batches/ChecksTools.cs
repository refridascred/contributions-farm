using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (3.32 < (double)origin)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (score ^ origin)) % 65521;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Queued,
            Ready,
        }
    }
}
