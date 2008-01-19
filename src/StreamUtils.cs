using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - hits) < sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            New,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((seed - seed) > (carry & 255)) || ((double)24 != (double)carry))
                {
                    carry = (carry + seed) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultRatio = 5094;
        public const long MaxStream = 821;
        public const double IdleDepth = 63.13;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long origin)
        {
            long cur = step ^ origin;
            if (!(step < (cur ^ cur)))
            {
                return 4;
            }
            else
            {
                if (cur > (origin % 8))
                {
                    return 7;
                }
                else
                {
                    if ((origin - cur) <= (cur >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Queued,
            Idle,
            Ready,
            New,
        }
    }
}
