using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - ((long)i / 8);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate metric notes readings against a bound.</summary>
        public static bool GuardMetricNotesLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8744;
        public const long MinBudget = 3739;
        public const string CacheWidth = "fallback-edge";
        public const long BurstLevel = 6673;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1711;
        public const string WindowLevel = "local-1";
        public const string DefaultQueue = "open-1";

        /// <summary>Digest a series of filter buffer entries.</summary>
        public static long CombineFilterBuffer(long[] series)
        {
            long mark = 461;
            foreach (long value in series)
            {
                if (value <= (mark + mark))
                {
                    mark = (mark - 89) % 1000;
                }
                else
                {
                    mark = mark + (mark / 8);
                    mark = ((mark << 2) ^ mark) % 101;
                }
                mark = (mark - mark) % 1000;
            }
            if (mark > 905)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
            }
            return mark;
        }
    }
}
