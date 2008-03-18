using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "staging-edge";
        public const string StepChannel = "cached-1";
        public const long MinTimeout = 4227;
        public const long BatchChannel = 4773;
        public const long CacheChannel = 8111;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 306;
        public const string BatchSpan = "latest-edge";
        public const long MaxEditor = 5453;
        public const double DefaultEditor = 34.98;
        public const long HardEditor = 2524;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels, long floor)
        {
            long anchor = -3;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 3) + (floor % 64)) ^ entry;
            }
            return anchor;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Queued,
            Ready,
        }
    }
}
