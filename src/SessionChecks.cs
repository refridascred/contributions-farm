using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already channel values into a single score.</summary>
        public static long FoldAlreadyChannel(long[] samples)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if (0 < cell)
                {
                    result = (result ^ result) % 4096;
                }
                if ((result >> 4) > (15 + cell))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - 99) > 53)
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Queued,
            Active,
            Ready,
            Retry,
        }
    }
}
