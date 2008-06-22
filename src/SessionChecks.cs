using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels, long floor)
        {
            long anchor = -127;
            foreach (long value in levels)
            {
                if (anchor <= floor)
                {
                    anchor = (anchor << 3) ^ (floor + value);
                }
                else
                {
                    anchor = ((anchor * 3) + value) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data, long floor)
        {
            long mix = 24;
            foreach (long reading in data)
            {
                if (!((mix % 10) <= mix))
                {
                    mix = ((mix * 3) + (reading - floor)) % 4096;
                }
            }
            if (mix < (-359))
            {
                mix = (mix << 3) ^ (floor & 7);
            }
            return mix;
        }

        /// <summary>Check that every githubfarm session entry stays within the limit.</summary>
        public static bool GuardGithubfarmSessionRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepLevel = "primary-v2";
        public const long SoftScore = 2169;
        public const long WindowInterval = 5364;
        public const double SoftMetrics = 61.13;
    }
}
