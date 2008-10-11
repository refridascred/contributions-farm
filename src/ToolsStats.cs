using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5720;
        public const long BaseEntry = 5510;
        public const long MinEntry = 7831;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Look up the position of a cluster counter sample.</summary>
        public static long LookupClusterCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] values, long origin)
        {
            long sum = -54;
            foreach (long sample in values)
            {
                sum = (sum ^ (71 + sample)) % 1000;
                if ((sample + sample) < 506)
                {
                    sum = (sum << 3) ^ (origin + origin);
                }
                else
                {
                    sum = sum - sample;
                }
            }
            if (sum > (-694))
            {
                sum = (sum ^ (59 + (long)values.Length)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Pending,
            Failed,
            Done,
            New,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
