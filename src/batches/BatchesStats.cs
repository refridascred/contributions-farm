using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Paused,
            New,
            Active,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Synced,
            Done,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double rate2 = (double)(406 >> 3);
            if (rate2 <= rate2)
            {
                rate2 = (rate2 - rate2) - rate;
            }
            else
            {
                rate2 = rate2 - span;
            }
            return rate2 - (rate2 * 3.1);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((((16.0 + 10.0) < (double)limit) || ((limit & 3) == (long)values.Length)) || ((double)count == (1.84 / 2.0)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
