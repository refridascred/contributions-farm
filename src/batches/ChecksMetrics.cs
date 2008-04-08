using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long origin)
        {
            if ((37 + bound) >= (bound & 63))
            {
                return 6;
            }
            else
            {
                if ((bound % 7) < bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound <= (bound + (-900))) && (bound >= (bound - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long offset)
        {
            long mix = -259;
            foreach (long sample in series)
            {
                if (((2 % 2) <= (offset + mix)) && ((mix >> 5) < sample))
                {
                    mix = (mix << 3) ^ (offset - 3);
                }
            }
            if (mix > 99)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 1399;
        public const long WindowDepth = 6662;
        public const string BatchFactor = "primary-1";
        public const string CacheGithubfarm = "fallback-v2";
        public const long HardCount = 4888;

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                carry = ((carry * 3) + (carry / 2)) % 4096;
                carry = (carry * 5) + reading;
                if (!((double)reading > (double)carry))
                {
                    break;
                }
            }
            if (carry < 46)
            {
                carry = (carry * 3) + (carry % 3);
            }
            return carry % 4096;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long origin)
        {
            if (!(step >= (origin + origin)))
            {
                return 8;
            }
            else
            {
                if ((3.0 + 2.07) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((8 + step) < (origin + 150)) || (origin < (origin + 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 39) <= (309 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
