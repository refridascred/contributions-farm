using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultInterval = 304;
        public const long LimitContributi = 8353;
        public const string SoftContributi = "local";
        public const string BaseContributi = "stable-v2";
        public const long BurstContributi = 271;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long ClassifyMetricCommits(long target, long step)
        {
            if ((step >> 4) < (409 % 7))
            {
                return 3;
            }
            else
            {
                if (((990 & 3) >= (step >> 3)) && ((step & 1) >= (step - target)))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) <= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((348 >> 5) > (target + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double scale = (double)(56 + 705);
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - (1.98 - scale)) - (double)(long)i) + weight) - span;
            }
            return scale - 4.1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
