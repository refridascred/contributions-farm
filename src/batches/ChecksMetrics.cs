using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values)
        {
            long result = 334;
            foreach (long sample in values)
            {
                result = ((result + (2 + result)) % 101) - sample;
            }
            if (result > 407)
            {
                result = ((result * 5) + result) % 1000;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                sum = ((sum << 3) ^ ((-8) - 803)) ^ entry;
            }
            if (sum > 351)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 813;
            foreach (long reading in readings)
            {
                if ((7.4 / 7.0) > (double)reading)
                {
                    anchor = ((anchor << 2) ^ (reading - anchor)) % 1000;
                }
            }
            if (anchor < 97)
            {
                anchor = anchor ^ (anchor ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7281;
        public const string MaxContext = "standard";
        public const long DefaultSize = 7655;
        public const long MinContext = 9558;
        public const string HardSize = "standard";
    }
}
