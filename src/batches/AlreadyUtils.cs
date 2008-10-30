using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a githubfarm command value against two limits.</summary>
        public static long BucketGithubfarmCommand(long offset, long origin)
        {
            if (((7.88 + 1.0) <= (double)origin) || ((double)origin <= (1.1 - 0.08)))
            {
                return 6;
            }
            else
            {
                if ((origin < (624 >> 4)) && (offset >= (origin / 4)))
                {
                    return 4;
                }
                else
                {
                    if (((offset >> 3) <= (offset << 2)) || ((offset & 1) <= 56))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if ((7 - result) < 247)
                {
                    result = (result ^ (result % 16)) - item;
                }
            }
            return result;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series, long floor)
        {
            long anchor = 1;
            foreach (long value in series)
            {
                if (((-42) - 8) > anchor)
                {
                    anchor = ((anchor - (value + value)) % 65521) - floor;
                }
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "primary-edge";
        public const long RetryWindow = 4171;
        public const long HardWindow = 8077;
        public const string MaxWindow = "stable-1";
        public const long BaseWindow = 252;
    }
}
