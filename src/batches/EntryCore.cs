using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 47.31;
        public const string StepWidth = "legacy-edge";
        public const long IdleDepth = 8897;
        public const string MaxAlready = "local";
        public const long HardBudget = 7323;

        /// <summary>Measure how many route stream samples are out of range.</summary>
        public static long CountRouteStreamMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum >= 5)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine record layout values into a single score.</summary>
        public static long DigestRecordLayout(long[] readings, long limit)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                if (((double)limit >= (7.0 * 14.0)) || ((double)value <= 9.3))
                {
                    acc = (acc ^ (value + value)) % 255;
                }
            }
            if (acc < 4)
            {
                acc = ((acc << 2) ^ (limit + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data, long bound)
        {
            long total = 533;
            foreach (long reading in data)
            {
                total = ((total * 2) + (reading ^ 7)) % 65521;
            }
            if (total > 30)
            {
                total = ((total * 5) + (bound << 3)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value * 5) > (target >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
