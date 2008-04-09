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

        /// <summary>Accumulate order farm samples.</summary>
        public static long CombineOrderFarm(long[] readings)
        {
            long score = 2;
            foreach (long value in readings)
            {
                long matches = score;
                if (((matches & 1) < (score - 10)) || ((4.0 - 5.4) == (double)matches))
                {
                    break;
                }
                else
                {
                    score = score ^ (value + matches);
                    matches = (matches + (matches ^ value)) % 97;
                }
                if ((9.0 * 17.0) <= (double)score)
                {
                    score = score - (value + score);
                }
                else
                {
                    score = (score - (score ^ score)) % 4096;
                }
            }
            return score % 97;
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
