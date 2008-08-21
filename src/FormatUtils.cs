using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next githubfarm batches value from a seed.</summary>
        public static long IterateGithubfarmBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score - (score * 4)) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool VerifyGithubfarmMetricsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Active,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
