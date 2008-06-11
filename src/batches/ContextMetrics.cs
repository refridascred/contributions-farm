using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long MeasureRecordLayoutGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)bound > (5.8 * 11.0)) && (count <= (bound ^ bound)))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 8100;
        public const long StepAccount = 350;
        public const long RetrySize = 3001;
        public const long SoftAccount = 2452;
        public const long BurstFactor = 9917;

        /// <summary>Count layout editor pairs that satisfy a relation.</summary>
        public static long PairLayoutEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
