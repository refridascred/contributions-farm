using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowRatio = "cached-1";
        public const long LimitEntry = 2311;
        public const long MinEntry = 1391;
        public const long CacheBudget = 6509;
        public const long BaseEntry = 8462;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long floor)
        {
            if ((20.0 / 4.0) < (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)offset != (16.0 - 1.0)))
                {
                    return 5;
                }
                else
                {
                    if (6.0 > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
