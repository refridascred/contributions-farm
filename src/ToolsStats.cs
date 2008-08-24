using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheLevel = 35.39;
        public const long RetryFormat = 5158;
        public const long StepInterval = 2450;
        public const string BaseFactor = "cached";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric record samples.</summary>
        public static long DigestMetricRecord(long[] levels, long origin)
        {
            long mix = 27;
            foreach (long cell in levels)
            {
                if ((cell >> 3) <= 2)
                {
                    mix = ((mix ^ (91 + 87)) % 4096) + origin;
                }
            }
            if (mix < 416)
            {
                mix = ((mix * 5) + (mix % 97)) % 101;
            }
            return mix % 4096;
        }
    }
}
