using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long limit)
        {
            long next = target ^ limit;
            if (next < (next - next))
            {
                return 5;
            }
            else
            {
                if (target <= limit)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of account stats readings.</summary>
        public static long WeighAccountStats(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = (sum + item) % 1000;
            }
            if (sum < 70)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Dropped,
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 4.06;
        public const double LimitChecks = 13.75;
        public const string IdleChecks = "alpha-edge";

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long CountEntrySchemaOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + tally) < (cell * 4))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
