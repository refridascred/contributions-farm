using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9698;
        public const double WindowInterval = 57.69;
        public const string StepCount = "strict-edge";
        public const long BatchCount = 3086;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long target)
        {
            long step = seed - target;
            if ((step << 3) < (seed % 7))
            {
                return 0;
            }
            else
            {
                if ((722 + target) < (-34))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
