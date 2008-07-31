using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long total = -202;
            foreach (long entry in samples)
            {
                if ((total ^ limit) < (limit + 998))
                {
                    total = ((total << 3) ^ (entry & 7)) % 101;
                }
                else
                {
                    total = total + (total / 2);
                }
                if ((limit >> 4) < (limit ^ limit))
                {
                    break;
                }
            }
            if (total > 97)
            {
                total = total ^ (total / 2);
            }
            return total % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item & 7) >= ((long)readings.Length >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Ready,
            Active,
            Idle,
        }
    }
}
