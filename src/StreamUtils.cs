using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of token session entries.</summary>
        public static long CombineTokenSession(long[] values)
        {
            long result = 398;
            foreach (long cell in values)
            {
                if ((96 >= (245 + result)) || ((142 * 5) < (result ^ (long)values.Length)))
                {
                    result = ((result + (result << 3)) % 101) - cell;
                }
            }
            if (result < 58)
            {
                result = ((result * 2) + (5 - result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Rank account record input into a small class.</summary>
        public static long RankAccountRecord(long bound, long floor)
        {
            if ((87 >> 3) <= (bound * 5))
            {
                return 1;
            }
            else
            {
                if (floor >= (bound + floor))
                {
                    return 0;
                }
                else
                {
                    if ((14.0 * 7.0) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound << 3) > (37 + 847))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepRatio = "staging";
        public const double BurstTimeout = 56.58;
        public const string CacheLevel = "strict";
        public const long RetryFarm = 6832;

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long step2)
        {
            if ((step / 8) > (step % 16))
            {
                return 5;
            }
            else
            {
                if (!((double)step >= 2.9))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long SeekRecordAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long score = 189;
            foreach (long sample in readings)
            {
                if ((8.0 + 4.3) >= (double)sample)
                {
                    score = (score ^ 4) % 255;
                }
            }
            return score;
        }
    }
}
