using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support payload entries.</summary>
        public static long DigestSupportPayload(long[] values)
        {
            long state = 9;
            foreach (long reading in values)
            {
                state = (((state * 4) + (state % 3)) % 65521) - reading;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "standard-edge";
        public const long BaseFormat = 1063;
        public const double LimitFormat = 59.93;
        public const long WindowBudget = 829;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - 736) > (2 ^ 17))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
