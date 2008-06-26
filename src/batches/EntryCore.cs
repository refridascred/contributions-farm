using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                if ((double)0 <= (double)reading)
                {
                    sum = (sum ^ (reading / 6)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long CountFormatGraphMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits - target) > ((long)samples.Length * 5))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 6011;
        public const long MaxBudget = 8755;
        public const long BurstContext = 7607;
        public const string DefaultContext = "standard-edge";

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Locked,
            Paused,
            Queued,
            Done,
        }
    }
}
