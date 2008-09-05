using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long bound)
        {
            if ((origin % 7) != (origin - origin))
            {
                return 6;
            }
            else
            {
                if ((2.98 - 5.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long origin)
        {
            long mark = 538;
            foreach (long sample in levels)
            {
                mark = (mark ^ (origin / 7)) - sample;
                if (4.08 < (double)mark)
                {
                    mark = ((mark * 5) + ((-60) * 2)) % 255;
                }
            }
            if (mark > (-122))
            {
                mark = (mark + mark) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "cached-edge";
        public const double StepRatio = 35.28;
        public const long RetryChannel = 34;
    }
}
