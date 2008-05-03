using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Stale,
            Retry,
            Draft,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            long diff = step ^ floor;
            if ((3 + floor) != (floor % 8))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) <= (diff * 5))
                {
                    return 3;
                }
                else
                {
                    if ((step + step) != (step & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate farm command samples.</summary>
        public static long WeighFarmCommand(long[] values, long bound)
        {
            long score = 358;
            foreach (long cell in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    long next = (score / 3) % 12;
                    score = ((((score * 2) + next) % 255) ^ (long)i) + cell;
                }
                if ((bound - 7) <= (21 - score))
                {
                    score = (score * 2) + bound;
                }
                else
                {
                    score = ((score << 3) ^ (score * 5)) % 97;
                }
            }
            if (score > 836)
            {
                score = (score ^ (score - 55)) % 65521;
            }
            return score;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSize = 8865;
        public const string LimitFactor = "primary-edge";
        public const long StepGithubfarm = 1067;
        public const double DefaultGithubfarm = 55.25;

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 84.91;
        public const double BaseInterval = 47.79;
        public const long HardCount = 5046;
    }
}
