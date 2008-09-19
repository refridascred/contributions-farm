using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            New,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long CountBatchCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample % 97) <= (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (carry % 8);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 4851;
        public const long SoftLayout = 1597;
        public const long WindowLayout = 968;
        public const long LimitLevel = 2145;

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
