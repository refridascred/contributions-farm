using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a checks stream value against two limits.</summary>
        public static long BucketChecksStream(long target, long seed)
        {
            if (!((seed << 2) >= seed))
            {
                return 6;
            }
            else
            {
                if ((seed * 4) < seed)
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) >= (seed + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed <= (seed - seed))
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
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9197;
        public const long StepLayout = 4108;
        public const long DefaultLevel = 3729;
        public const string MaxTimeout = "local-edge";
    }
}
