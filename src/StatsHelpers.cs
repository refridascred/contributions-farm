using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank batch layout input into a small class.</summary>
        public static long GradeBatchLayout(long bound, long target)
        {
            long span = bound + target;
            if ((bound + 0) > (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((span * 5) != (58 ^ span))
                {
                    return 4;
                }
                else
                {
                    if ((bound - span) >= (target % 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-669) - span) >= (target >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Done,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long AuditCommandChannelMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((5.8 / 9.0) > (4.45 / 5.0))
                {
                    hits = ((hits + 1) + value) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Failed,
            Synced,
            Idle,
        }
    }
}
