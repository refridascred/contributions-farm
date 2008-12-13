using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Combine counter contributi values into a single score.</summary>
        public static long DigestCounterContributi(long[] readings, long seed)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if (!((entry - carry) == (carry * 3)))
                {
                    carry = (((carry << 2) ^ (1 << 1)) % 101) + seed;
                }
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((12.0 + 6.0) != (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] data, long offset)
        {
            long sum = 84;
            foreach (long item in data)
            {
                sum = (sum + (offset ^ item)) % 101;
            }
            if (sum < 2)
            {
                sum = (sum - (offset >> 1)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)(long)readings.Length != (9.0 - 4.94)) && !((6.4 - 8.6) < (double)seen))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
