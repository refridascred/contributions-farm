using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate filter queue samples.</summary>
        public static long WeighFilterQueue(long[] levels)
        {
            long anchor = 152;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 5) + (5 + 6)) % 4096;
                if (66 >= (entry % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Done,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long origin, long seed)
        {
            if ((origin > (origin + origin)) || ((origin << 1) > (-54)))
            {
                return 1;
            }
            else
            {
                if ((double)origin > 8.1)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "standard-edge";
        public const double MaxBudget = 55.0;
        public const string HardGithubfarm = "latest-1";
        public const double DefaultGithubfarm = 11.66;
        public const long MaxDepth = 6138;

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long step)
        {
            long step2 = seed ^ step;
            if ((step2 * 5) > (step & 3))
            {
                return 2;
            }
            else
            {
                if (step > seed)
                {
                    return 8;
                }
                else
                {
                    if ((step2 ^ step) != (seed / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.5 * 8.0) != (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
