using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long seed)
        {
            if (target <= (target * 4))
            {
                return 6;
            }
            else
            {
                if ((seed - seed) >= (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((seed * 2) != (target / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((41 & 31) < (target + 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (origin & 31))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long datum in series)
            {
                anchor = (((anchor << 2) ^ (anchor + datum)) % 255) + seed;
            }
            return anchor;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Pending,
            Locked,
        }
    }
}
