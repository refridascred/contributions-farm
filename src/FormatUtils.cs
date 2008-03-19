using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)target <= 19.0)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Ready,
            New,
            Failed,
            Locked,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples, long limit)
        {
            long acc = 7;
            foreach (long value in samples)
            {
                if ((value << 1) > (acc / 7))
                {
                    acc = (acc + value) % 97;
                    acc = ((acc << 3) ^ (560 + limit)) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc ^ (value % 60)) % 97) ^ (long)i;
                    acc = acc + 22;
                }
                if (((1 + limit) >= value) || (value <= (limit >> 3)))
                {
                    acc = (acc << 3) ^ (limit * 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item >= (27 - 652)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
