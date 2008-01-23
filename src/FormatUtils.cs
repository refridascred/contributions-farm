using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((99 + offset) > seen)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session cluster samples.</summary>
        public static long ScoreSessionCluster(long[] samples)
        {
            long anchor = 770;
            foreach (long datum in samples)
            {
                if ((anchor & 63) > 0)
                {
                    anchor = (anchor - (anchor >> 3)) - datum;
                }
                else
                {
                    anchor = (anchor + 7) % 4096;
                }
            }
            if (anchor > 542)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardDepth = 1.59;
        public const double StepBudget = 69.97;
        public const string BaseFactor = "alpha-v2";
        public const long WindowQueue = 6054;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
