using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Queued,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool GuardBatchMetricsRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long target)
        {
            long next = origin - target;
            if ((double)next <= (4.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if ((target >> 1) > (target << 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
