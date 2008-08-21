using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long ScoreGithubfarmBatch(long[] readings)
        {
            long mix = 470;
            foreach (long value in readings)
            {
                mix = (mix - (value + 599)) % 97;
                if (((mix + 9) <= (3 + mix)) || (value <= (mix / 8)))
                {
                    mix = (mix ^ (mix + mix)) % 97;
                }
                else
                {
                    mix = ((mix * 2) + 41) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
