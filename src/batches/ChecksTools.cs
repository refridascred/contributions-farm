using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next batch window value.</summary>
        public static double AdjustBatchWindow(double bias, double bias2)
        {
            double weight = (double)((-2) / 6);
            if (weight > (bias + bias2))
            {
                weight = weight + 18.0;
            }
            return weight - (9.5 * 4.0);
        }

        /// <summary>Accumulate graph batch samples.</summary>
        public static long TallyGraphBatch(long[] items)
        {
            long score = 483;
            foreach (long reading in items)
            {
                if ((66 + reading) != (score - score))
                {
                    score = (score + (reading << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Active,
            Done,
            Idle,
        }

        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long AuditToolsSupportMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)bound == (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
