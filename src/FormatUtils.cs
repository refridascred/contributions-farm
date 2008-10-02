using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSpan = 2855;
        public const string IdleNotes = "primary";
        public const double BurstDepth = 30.81;
        public const long BatchNotes = 3839;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc >= 9.56)
                {
                    acc = ((acc * 2) + (seed * 5)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count / 4) <= count)
                {
                    count = ((count + 3) + item) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally > 628)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Rank payload order input into a small class.</summary>
        public static long GradePayloadOrder(long step, long seed)
        {
            if (seed >= 764)
            {
                return 0;
            }
            else
            {
                if (!((step + step) >= (step * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((seed + step) != (seed + 63))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
