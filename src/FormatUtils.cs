using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstInterval = "standard-1";
        public const long WindowRatio = 2323;
        public const long RetryCounter = 4752;
        public const long HardRatio = 4119;
        public const long MinCounter = 8983;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate layout support readings against a bound.</summary>
        public static bool ValidateLayoutSupportLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                if ((mix % 3) < (item ^ 26))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 101;
                }
                else
                {
                    mix = mix + mix;
                    mix = mix - (mix + 6);
                }
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix - mix)) % 65521) ^ (long)i;
                }
                mix = ((mix * 3) + mix) % 97;
            }
            return mix;
        }
    }
}
