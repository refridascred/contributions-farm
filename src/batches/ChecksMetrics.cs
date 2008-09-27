using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 3135;
        public const double LimitGraph = 86.91;
        public const long BurstBudget = 6419;
        public const long CacheGraph = 6642;
        public const long BurstSpan = 9055;

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items, long step)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = (acc ^ (reading % 12)) - step;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 7726;
        public const string BaseNotes = "latest";
        public const double SoftBudget = 86.18;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length != (23 & 1))
                {
                    count = ((count + 1) + cell) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
