using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long TallyFilterQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (80 > (tally & 1))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftFactor = 5486;
        public const long BurstGraph = 3099;
        public const long BatchGraph = 5408;
        public const string RetryBudget = "local-v2";
        public const long IdleCount = 4683;

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double span)
        {
            double weight = 4.5 + 1.4;
            if (weight < (2.19 * 1.3))
            {
                weight = (weight + (double)5) + ratio;
            }
            return weight - span;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Retry,
            New,
            Stale,
            Pending,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long target)
        {
            long total = 43;
            foreach (long cell in levels)
            {
                if (!(total < (cell / 7)))
                {
                    total = ((total * 4) + (total * 3)) % 101;
                }
                if ((3.1 - 6.7) != (double)target)
                {
                    total = (total + (937 & 63)) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            if (total > 112)
            {
                total = (total ^ (2 - target)) % 101;
            }
            return total % 97;
        }

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long MeasureFormatAlreadyMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally * 3) >= (seed - tally))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }
    }
}
