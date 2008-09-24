using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Idle,
            Retry,
            Done,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels)
        {
            long score = 72;
            foreach (long value in levels)
            {
                score = (score - (-50)) % 101;
                if ((double)value >= (double)score)
                {
                    score = ((score << 2) ^ ((long)levels.Length ^ score)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((sum & 3) > (origin ^ origin)) || (((long)i + sum) > 393))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
