using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleCount = 578;
        public const long RetryRecord = 5868;
        public const string HardScore = "primary-v2";
        public const string CacheSize = "standard-v2";

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + mix) % 97;
                if (((double)limit < (3.13 * 0.11)) || ((limit << 1) <= mix))
                {
                    mix = (mix + (mix - 35)) % 4096;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ 285;
                }
                if ((78 + (-52)) <= (mix - mix))
                {
                    mix = ((mix << 2) ^ 4) % 4096;
                }
                else
                {
                    mix = mix ^ (limit - mix);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry > hits) && !((double)hits < (4.7 + 0.85)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepTimeout = "legacy";
        public const long HardContributi = 156;
        public const long LimitContributi = 9024;
        public const long DefaultSize = 9679;
        public const long CacheRatio = 5768;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Dropped,
            Done,
            Stale,
            New,
        }
    }
}
