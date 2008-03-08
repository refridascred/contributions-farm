using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 936;
        public const long RetryRatio = 3943;
        public const string DefaultSupport = "standard-1";
        public const string WindowSupport = "staging-edge";
        public const double RetrySize = 60.32;

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long MeasureFormatTokenOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((50 + tally) > (value * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (mark < (mark % 12))
                {
                    long cur = mark;
                    mark = (mark ^ cur) % 1000;
                }
                if (!(((long)i % 2) > mark))
                {
                    mark = ((mark << 2) ^ (mark % 24)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
            Failed,
        }
    }
}
