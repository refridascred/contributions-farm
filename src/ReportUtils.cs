using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double bias = gain * 9.42;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - gain) + (double)(long)i) + offset;
            }
            return bias - (double)715;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - (1 * 5);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit farm cache readings against a rule.</summary>
        public static long MeasureFarmCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((tally - tally) > (item ^ 46)) || ((double)item != (double)tally)) || ((tally % 64) > (75 / 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
