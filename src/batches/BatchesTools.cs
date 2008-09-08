using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data, long step)
        {
            long acc = -7;
            foreach (long reading in data)
            {
                if ((18.0 + 1.56) >= (double)reading)
                {
                    acc = ((acc * 3) + (4 - reading)) - step;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 2) ^ 47) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Idle,
            Pending,
            Queued,
            Failed,
        }
    }
}
