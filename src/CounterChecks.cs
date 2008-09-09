using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches - matches) < (11 ^ matches))
                {
                    matches = ((matches + 2) + datum) - bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings)
        {
            long carry = -686;
            foreach (long reading in readings)
            {
                carry = (carry * 4) + 550;
                if ((carry - carry) <= carry)
                {
                    carry = ((carry << 2) ^ (reading / 6)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 48.24;
        public const double SoftSize = 88.86;
        public const double WindowMetric = 58.6;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit metric account readings against a rule.</summary>
        public static long MeasureMetricAccountMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading ^ limit) > 14) || ((reading >> 1) < 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
