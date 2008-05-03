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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if (((offset + 22) <= 0) || (4 < (limit - offset)))
            {
                return 4;
            }
            else
            {
                if (!((offset2 / 4) > offset2))
                {
                    return 0;
                }
                else
                {
                    if ((706 << 1) < offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) >= entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 84.91;
        public const double BaseInterval = 47.79;
        public const long HardCount = 5046;
    }
}
