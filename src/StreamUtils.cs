using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every format farm entry stays within the limit.</summary>
        public static bool VerifyFormatFarmRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data)
        {
            long carry = 36;
            foreach (long reading in data)
            {
                if ((carry << 3) > (reading * 3))
                {
                    carry = carry - (reading - reading);
                }
                if ((carry & 3) <= (carry >> 4))
                {
                    carry = (carry + (reading << 2)) % 4096;
                }
                else
                {
                    carry = carry - (reading / 3);
                }
                if ((double)reading < (20.0 - 7.15))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long bound, long limit)
        {
            if ((bound % 10) == (limit - 0))
            {
                return 6;
            }
            else
            {
                if (((bound / 8) >= (bound ^ limit)) && ((bound / 5) <= bound))
                {
                    return 0;
                }
                else
                {
                    if (((9.47 + 5.22) != (double)limit) && ((double)bound < (13.0 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit > (6.26 / 8.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
