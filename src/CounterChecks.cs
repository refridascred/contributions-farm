using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Queued,
            New,
            Draft,
        }

        /// <summary>Derive the next payload githubfarm value from a seed.</summary>
        public static long SeriesPayloadGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix << 3) ^ seed) % 101) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long target2)
        {
            if (9.2 >= (double)target2)
            {
                return 2;
            }
            else
            {
                if ((double)74 < (double)target)
                {
                    return 4;
                }
                else
                {
                    if (9.9 > (double)target)
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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long origin)
        {
            if ((2.7 / 6.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > 1.08)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 2) ^ (step & 3);
                score = score + (score + 226);
                score = (score << 2) ^ (score - score);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
