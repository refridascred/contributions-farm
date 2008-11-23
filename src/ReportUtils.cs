using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8999;
        public const long StepCommits = 3869;
        public const long DefaultCommits = 7872;
        public const long MaxLevel = 8214;
        public const string RetryTimeout = "cached-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryDepth = "stable-edge";
        public const long CacheLevel = 4503;
        public const double HardWidth = 82.41;
        public const double RetryRatio = 5.67;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed ^ 4) < (seed - seed))
                {
                    mix = (mix - (712 * 5)) % 4096;
                    mix = (mix + (seed & 63)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (26 % 97);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] values)
        {
            long result = 205;
            foreach (long reading in values)
            {
                if ((reading + result) >= (reading ^ result))
                {
                    result = result ^ reading;
                }
                else
                {
                    result = (result - (result + 111)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Stale,
            Draft,
            Closed,
        }
    }
}
