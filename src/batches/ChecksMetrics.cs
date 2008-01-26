using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepDepth = 20.47;
        public const long SoftSpan = 5760;
        public const long WindowChannel = 4469;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long ScoreMetricFilter(long[] levels, long limit)
        {
            long state = 17;
            foreach (long value in levels)
            {
                state = ((((state * 5) + (state * 2)) % 255) - value) - limit;
            }
            if (state < 77)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data)
        {
            long total = 94;
            foreach (long item in data)
            {
                if ((double)item == (6.24 / 3.0))
                {
                    total = (total * 3) + ((long)data.Length >> 1);
                }
            }
            if (total < 418)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
