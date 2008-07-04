using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSpan = 9431;
        public const long HardRatio = 4430;
        public const string HardChannel = "staging-edge";
        public const string SoftWidth = "fallback-1";

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long target2)
        {
            if (((double)target >= (2.46 * 7.0)) && (target2 < (target ^ target2)))
            {
                return 2;
            }
            else
            {
                if (((target2 >> 5) <= (target & 255)) || ((target + target2) < (target - target)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long target, long step)
        {
            long gap = target - step;
            if ((target % 24) <= (target + target))
            {
                return 5;
            }
            else
            {
                if (((gap / 3) <= gap) || ((target + 0) >= (gap - target)))
                {
                    return 0;
                }
                else
                {
                    if (step >= (target % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long floor)
        {
            if (floor <= (758 + 56))
            {
                return 0;
            }
            else
            {
                if (floor >= (269 >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 3) == (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            New,
            Active,
        }
    }
}
