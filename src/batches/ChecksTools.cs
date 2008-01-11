using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 502;
        public const double DefaultFarm = 63.08;
        public const double RetrySize = 44.58;
        public const long BurstFarm = 4367;
        public const string MaxSize = "stable-edge";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long seed)
        {
            long acc = 46;
            foreach (long item in readings)
            {
                acc = (acc + item) % 4096;
                if ((double)item >= 3.0)
                {
                    acc = acc + (seed + seed);
                }
                if (((acc + acc) >= acc) || (7 < (seed - item)))
                {
                    break;
                }
            }
            if (acc < 490)
            {
                acc = (acc * 2) + (425 << 3);
            }
            return acc;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
