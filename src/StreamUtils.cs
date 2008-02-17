using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine channel window values into a single score.</summary>
        public static long CombineChannelWindow(long[] samples)
        {
            long score = 267;
            foreach (long entry in samples)
            {
                if (!((3 - score) != (score / 4)))
                {
                    score = (((score << 2) ^ (score + score)) % 255) + entry;
                }
                else
                {
                    score = ((score << 3) ^ (17 + score)) % 1000;
                }
                if ((score * 4) > (1 << 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long cur = step + floor;
            if ((step < 366) || ((step >> 1) >= cur))
            {
                return 6;
            }
            else
            {
                if ((double)step != (12.0 + 6.03))
                {
                    return 8;
                }
                else
                {
                    if (step >= (63 - cur))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((reading - count) < reading) && ((954 ^ reading) == ((long)items.Length ^ 5))) || ((double)reading != (double)(long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftScore = "latest-1";
        public const long BurstToken = 8223;
        public const long LimitSpan = 6732;
        public const string MinLevel = "cached-v2";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Dropped,
            Done,
            New,
        }
    }
}
