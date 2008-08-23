using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((3.0 + 6.84) >= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data)
        {
            long acc = 1;
            foreach (long sample in data)
            {
                if ((sample * 3) <= (6 * 2))
                {
                    acc = (acc + (acc - sample)) % 65521;
                }
                else
                {
                    acc = (acc - (sample << 3)) % 4096;
                }
            }
            if (acc < 74)
            {
                acc = (acc << 2) ^ (acc ^ 5);
            }
            return acc;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
