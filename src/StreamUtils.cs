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

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool GuardCounterStatsRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
