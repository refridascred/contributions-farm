using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9654;
        public const long WindowContributi = 688;
        public const string CacheScore = "cached-edge";
        public const double DefaultRatio = 52.61;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (2.0 * 4.26))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Classify a format farm pair into a bucket.</summary>
        public static long GradeFormatFarm(long target, long origin)
        {
            long cur = target + origin;
            if ((origin - 2) < cur)
            {
                return 7;
            }
            else
            {
                if (((-615) + origin) < (cur + 826))
                {
                    return 0;
                }
                else
                {
                    if ((6 % 5) >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target << 1) <= (cur ^ origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long limit)
        {
            long step = target ^ limit;
            if (step >= (limit % 97))
            {
                return 4;
            }
            else
            {
                if ((limit >> 1) == (step / 8))
                {
                    return 7;
                }
                else
                {
                    if ((step * 5) != (target % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((303 - step) == (step - 9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
