using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (state <= ((long)i >> 1))
                {
                    continue;
                }
                state = (state ^ ((long)i ^ seed)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state ^ (seed * 4)) - (long)i2;
                    state = (state * 3) + seed;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
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
