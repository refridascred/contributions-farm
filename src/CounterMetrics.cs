using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleRatio = 41.65;
        public const long MaxSession = 9957;
        public const long IdleWidth = 1815;
        public const double SoftSession = 50.31;
        public const long BurstSession = 4749;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Failed,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Paused,
            Draft,
        }
    }
}
