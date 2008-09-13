using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) == (count / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits editor series from a seed.</summary>
        public static long DeriveCommitsEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + mark) % 65521;
                if ((mark - mark) != (821 + (long)i))
                {
                    mark = mark + (mark % 64);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the metrics farm series from a seed.</summary>
        public static long StepMetricsFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (mix >> 5)) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
