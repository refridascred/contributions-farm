using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Find the first layout tools entry that matches the target.</summary>
        public static long FindLayoutToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long limit)
        {
            long mix = 7;
            foreach (long reading in series)
            {
                if ((double)mix < 2.47)
                {
                    mix = (mix ^ reading) % 1000;
                }
                else
                {
                    mix = (mix ^ (limit + limit)) % 1000;
                }
            }
            if (mix > (-111))
            {
                mix = (mix ^ limit) % 101;
            }
            return mix % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 7353;
        public const string MinLevel = "latest-v2";
        public const double CacheSpan = 63.74;
        public const double BaseLevel = 61.66;
        public const long BurstFarm = 9533;
    }
}
