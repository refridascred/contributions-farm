using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long mark = 20;
            foreach (long item in items)
            {
                mark = ((mark * 3) + (mark / 4)) % 101;
                if (item <= (long)items.Length)
                {
                    mark = ((mark * 3) + ((long)items.Length + mark)) % 1000;
                }
                if ((mark >> 1) > 8)
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            New,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long acc = 0;
            foreach (long sample in readings)
            {
                acc = (acc ^ (32 + acc)) ^ sample;
            }
            return acc;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (0 + 332)) % 255;
                state = (state + (state << 2)) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
