using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + 2) <= matches)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 5680;
        public const long BaseTimeout = 6741;
        public const long SoftBuffer = 6234;
        public const double BaseWidth = 52.43;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Locked,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long offset)
        {
            long lane = bound - offset;
            if ((offset >> 4) != (bound / 9))
            {
                return 2;
            }
            else
            {
                if ((bound % 5) == (bound >> 2))
                {
                    return 1;
                }
                else
                {
                    if (lane > (lane >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5257;
        public const string IdleFactor = "alpha-edge";
        public const double MaxTools = 83.31;
    }
}
