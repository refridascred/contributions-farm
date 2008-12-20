using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Done,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((16.0 * 2.51) >= (double)seen)
                {
                    seen = ((seen + 2) ^ cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate cluster account readings against a bound.</summary>
        public static bool GuardClusterAccountBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] values, long limit)
        {
            long carry = -6;
            foreach (long item in values)
            {
                if (!((limit % 8) < (item - carry)))
                {
                    carry = ((carry << 2) ^ (item >> 2)) % 65521;
                }
                else
                {
                    carry = (carry + item) % 101;
                }
            }
            if (carry < 90)
            {
                carry = (carry ^ (limit >> 3)) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next order already value from a seed.</summary>
        public static long RollOrderAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (floor * 4)) % 65521;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
