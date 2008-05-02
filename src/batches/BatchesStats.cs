using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Ready,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Validate report stats readings against a bound.</summary>
        public static bool VerifyReportStatsRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples, long target)
        {
            long sum = 269;
            foreach (long datum in samples)
            {
                sum = (sum ^ ((-4) - datum)) % 65521;
                if (((8.46 * 8.3) > (double)sum) || ((sum & 7) <= (sum + target)))
                {
                    sum = ((sum * 2) + (1 + sum)) % 4096;
                }
                if (target < (target + datum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
