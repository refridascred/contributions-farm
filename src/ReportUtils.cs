using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool ValidateSchemaRouteRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile githubfarm values into a single score.</summary>
        public static long FoldProfileGithubfarm(long[] series, long target)
        {
            long carry = -2;
            foreach (long sample in series)
            {
                if ((carry >> 2) == (target / 8))
                {
                    carry = ((carry * 4) + (carry - target)) - sample;
                }
                if ((carry << 2) >= (carry + target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit already counter readings against a rule.</summary>
        public static long TallyAlreadyCounterGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - entry) <= ((long)values.Length + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double rate = 15.0 - 2.68;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - span;
            }
            return rate + (double)60;
        }
    }
}
