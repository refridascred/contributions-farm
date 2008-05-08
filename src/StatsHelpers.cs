using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((count - step) > (step ^ step)) || ((6.51 + 1.4) >= (double)entry)) && (((355 + count) > (count - step)) || (6 >= (count + step))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((10.0 * 6.9) < (double)bound)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values)
        {
            long score = 594;
            foreach (long value in values)
            {
                long count = (score - score) ^ (value >> 2);
                score = ((score << 2) ^ count) % 255;
                if ((941 ^ score) < (value - value))
                {
                    score = score ^ (score ^ 30);
                }
            }
            return score;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            long diff = limit - target;
            if (!((diff ^ target) < (target + limit)))
            {
                return 4;
            }
            else
            {
                if ((double)target <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((diff > (diff + limit)) || (limit >= 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
