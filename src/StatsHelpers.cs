using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items)
        {
            long acc = 816;
            foreach (long item in items)
            {
                if (((item + item) <= acc) || ((7.5 - 1.69) != (double)item))
                {
                    acc = acc + (2 * 5);
                }
                if ((double)acc >= (5.3 - 3.6))
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Count the window commits entries that pass the check.</summary>
        public static long AuditWindowCommitsOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (offset > (entry ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long limit)
        {
            long total = -109;
            foreach (long entry in series)
            {
                if ((limit - entry) < limit)
                {
                    total = ((total << 3) ^ (total >> 5)) % 65521;
                }
                total = (total ^ (entry ^ 2)) % 255;
            }
            if (total > 241)
            {
                total = (total ^ (total >> 2)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long acc = 141;
            foreach (long item in samples)
            {
                if ((double)item <= 2.18)
                {
                    acc = ((acc + (item & 31)) % 4096) + origin;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "stable-edge";
        public const long LimitCommand = 812;
        public const string BurstBudget = "latest";
        public const long BaseCommand = 9473;
        public const string DefaultCommand = "standard";
    }
}
