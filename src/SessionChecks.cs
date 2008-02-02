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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ (score ^ limit)) % 4096;
                score = score ^ (score - limit);
                if (((score ^ 8) >= (score % 16)) && ((9.96 - 2.39) == (double)limit))
                {
                    score = score + score;
                    score = score - (score ^ (long)i);
                    continue;
                }
                else
                {
                    score = score ^ limit;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
