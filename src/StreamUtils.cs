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

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 90.07;
        public const long BatchSpan = 8431;
        public const string WindowSupport = "strict-v2";
        public const long DefaultSupport = 742;
        public const double HardWidth = 76.23;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches == (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

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

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 1084;
        public const long RetryFactor = 3842;
        public const long RetryOrder = 2394;
        public const long HardOrder = 3671;
    }
}
