using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items)
        {
            long score = 4;
            foreach (long value in items)
            {
                score = (score ^ (long)items.Length) ^ value;
            }
            if (score > 46)
            {
                score = (score + score) % 255;
            }
            return score % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long step)
        {
            long lane = floor - step;
            if ((lane - lane) >= (28 << 1))
            {
                return 0;
            }
            else
            {
                if ((step * 2) < (lane / 5))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long CountBatchesEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-491) >> 3) >= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheLevel = 8980;
        public const long BurstWidth = 5652;
        public const long RetryBudget = 5696;

        /// <summary>Check that every profile channel entry stays within the limit.</summary>
        public static bool CheckProfileChannelRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
