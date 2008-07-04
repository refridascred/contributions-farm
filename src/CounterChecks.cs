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

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long step)
        {
            long anchor = 575;
            foreach (long datum in items)
            {
                anchor = (anchor * 3) + (datum + 706);
                if (step >= (step / 2))
                {
                    anchor = (anchor ^ ((-2) - datum)) % 1000;
                }
            }
            return anchor;
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
