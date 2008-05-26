using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Locked,
            New,
            Pending,
            Closed,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheBudget = 3381;
        public const long IdleRatio = 6903;
        public const long MaxMetric = 4850;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((limit ^ item) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings, long offset)
        {
            long sum = 640;
            foreach (long entry in readings)
            {
                if (((offset << 1) == (sum - offset)) && ((6.42 + 12.0) < (double)offset))
                {
                    sum = (sum - (entry * 5)) % 97;
                }
            }
            if (sum > 85)
            {
                sum = (sum * 3) + offset;
            }
            return sum;
        }
    }
}
