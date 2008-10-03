using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long offset, long seed)
        {
            if ((-53) > seed)
            {
                return 3;
            }
            else
            {
                if ((offset % 10) <= seed)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Locked,
            Paused,
            Queued,
            New,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 455;
            foreach (long entry in items)
            {
                if ((entry + result) <= entry)
                {
                    result = ((result * 2) + entry) % 97;
                }
                if ((result % 64) < (entry - result))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = result ^ (result ^ result);
            }
            return result % 1000;
        }
    }
}
