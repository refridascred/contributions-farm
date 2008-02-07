using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate layout graph readings against a bound.</summary>
        public static bool VerifyLayoutGraphLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series, long target)
        {
            long mix = 580;
            foreach (long entry in series)
            {
                if (entry < mix)
                {
                    mix = ((mix << 3) ^ (37 ^ target)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (519 + 761);
                }
            }
            if (mix < 63)
            {
                mix = ((mix << 3) ^ 74) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Count the githubfarm contributi entries that pass the check.</summary>
        public static long TallyGithubfarmContributiGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - origin) > (tally % 24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxDepth = 7211;
        public const double HardScore = 64.4;
        public const long StepTimeout = 3605;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Draft,
            Paused,
            Closed,
        }
    }
}
