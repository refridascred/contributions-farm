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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum * 5) + offset) - (long)i2;
                    sum = ((sum << 3) ^ (sum * 2)) % 1000;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    sum = (((sum << 3) ^ (offset * 3)) % 97) ^ (long)i3;
                    sum = sum ^ offset;
                }
                for (int i4 = 0; i4 < 2; i4++)
                {
                    sum = (sum * 3) + (98 + (long)i);
                    sum = ((sum * 4) + ((long)i4 >> 2)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
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
