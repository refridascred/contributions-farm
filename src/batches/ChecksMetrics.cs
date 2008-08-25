using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Queued,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((origin + item) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
