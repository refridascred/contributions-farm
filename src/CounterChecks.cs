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

        /// <summary>Measure how many already route samples are out of range.</summary>
        public static long TallyAlreadyRouteMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((4.0 - 5.4) != (double)floor)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
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
