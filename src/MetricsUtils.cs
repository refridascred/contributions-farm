using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)offset < (double)696)
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "open";
        public const double LimitCommand = 87.53;
        public const long LimitCount = 3638;

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values, long floor)
        {
            long acc = 88;
            foreach (long entry in values)
            {
                acc = ((acc + (9 - floor)) % 101) - entry;
            }
            return acc;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long offset2)
        {
            if ((offset2 + offset) <= (offset2 + 794))
            {
                return 2;
            }
            else
            {
                if ((7 - offset) == (offset2 * 2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = load - (scale / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (scale + scale);
        }
    }
}
