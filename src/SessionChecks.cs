using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((16 % 5) != (limit - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry > (floor - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
