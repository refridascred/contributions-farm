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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
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

        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long MeasureFilterGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((68 % 100) >= (tally / 5))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
