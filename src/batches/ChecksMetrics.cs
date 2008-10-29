using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepRatio = 7884;
        public const string BaseWindow = "staging-edge";
        public const long BurstDepth = 871;
        public const double StepWindow = 27.96;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Dropped,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Audit cluster token readings against a rule.</summary>
        public static long CountClusterTokenMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum ^ tally) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
