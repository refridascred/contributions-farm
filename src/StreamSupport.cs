using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((904 < acc) && (6.58 >= (double)limit))
                {
                    acc = (acc - ((long)i << 2)) % 1000;
                }
                acc = acc ^ ((long)i % 3);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
