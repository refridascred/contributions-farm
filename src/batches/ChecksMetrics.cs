using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long seed)
        {
            long lane = limit ^ seed;
            if (!((460 + lane) >= (seed / 5)))
            {
                return 1;
            }
            else
            {
                if ((limit - 68) <= 6)
                {
                    return 5;
                }
                else
                {
                    if ((2.0 - 9.9) < (double)lane)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed >> 4) >= limit) || ((seed << 2) != (seed ^ lane)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstInterval = "strict-v2";
        public const long BurstTimeout = 7540;
        public const long CacheFactor = 176;
        public const double MinLevel = 83.79;
        public const long HardFormat = 1548;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 6351;
        public const string SoftToken = "stable-v2";
        public const string WindowScore = "open";
        public const long MaxToken = 1496;
        public const long BatchToken = 701;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if ((bound - bound) > (bound & 127))
            {
                return 6;
            }
            else
            {
                if ((45 + floor) <= bound)
                {
                    return 4;
                }
                else
                {
                    if (((9.22 / 9.0) >= (double)floor) && ((6 << 1) < (bound / 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate checks commits samples.</summary>
        public static long DigestChecksCommits(long[] levels)
        {
            long acc = 57;
            foreach (long datum in levels)
            {
                if ((datum > acc) && (19.0 <= (double)acc))
                {
                    acc = ((acc * 4) + (datum / 8)) % 97;
                }
            }
            if (acc > 47)
            {
                acc = (acc - (400 % 7)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] readings, long step)
        {
            long acc = 59;
            foreach (long sample in readings)
            {
                if ((28 & 31) >= (8 - sample))
                {
                    acc = acc ^ ((-96) - 294);
                }
            }
            if (acc > 93)
            {
                acc = ((acc * 3) + (step >> 3)) % 1000;
            }
            return acc;
        }
    }
}
