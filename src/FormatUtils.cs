using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

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

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowLevel = 473;
        public const double WindowCount = 18.76;
        public const long StepSession = 1063;
        public const double MinRatio = 78.6;
        public const string MaxSession = "staging-1";

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
