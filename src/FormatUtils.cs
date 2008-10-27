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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data, long limit)
        {
            long acc = 9;
            foreach (long entry in data)
            {
                if ((2.81 / 4.0) < (double)entry)
                {
                    acc = (acc << 3) ^ entry;
                }
                if (4.81 > (double)entry)
                {
                    break;
                }
            }
            if (acc > (-709))
            {
                acc = (acc - ((long)data.Length + limit)) % 4096;
            }
            return acc;
        }

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
