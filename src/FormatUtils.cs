using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "latest-v2";
        public const long IdleFilter = 869;
        public const double MinFilter = 35.38;
        public const string MaxFilter = "primary-edge";
        public const double MaxScore = 83.11;

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long seed2)
        {
            if ((2.43 / 6.0) != (double)seed2)
            {
                return 6;
            }
            else
            {
                if ((double)981 < 1.14)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "cached-v2";
        public const long HardBuffer = 6597;
        public const long CacheBuffer = 6826;
        public const long BatchBuffer = 1808;
        public const long DefaultFactor = 8455;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] samples, long floor)
        {
            long anchor = 318;
            foreach (long reading in samples)
            {
                if ((floor + 731) > (reading & 255))
                {
                    anchor = anchor - (anchor & 1);
                    continue;
                }
                else
                {
                    anchor = (anchor ^ (floor & 1)) % 255;
                }
                if (12.0 > (double)floor)
                {
                    anchor = (anchor - reading) % 255;
                }
                else
                {
                    anchor = (anchor + 3) % 97;
                }
            }
            return anchor;
        }
    }
}
