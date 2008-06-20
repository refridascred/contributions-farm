using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count >> 2) >= (cell + count)) || ((449 + count) < (count / 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record account readings.</summary>
        public static long FoldRecordAccount(long[] items, long floor)
        {
            long state = 7;
            foreach (long sample in items)
            {
                if (!((9.7 / 4.0) < (double)sample))
                {
                    state = (((state << 2) ^ state) % 97) - floor;
                }
            }
            return state;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long origin)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                carry = ((carry * 5) + origin) % 4096;
                if (((-939) + carry) > origin)
                {
                    carry = carry - 8;
                }
                if (entry >= (origin + entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] readings, long step)
        {
            long acc = 81;
            foreach (long entry in readings)
            {
                if ((entry % 12) >= 1)
                {
                    acc = (acc * 5) + (entry << 2);
                }
                else
                {
                    acc = acc ^ acc;
                }
                if ((entry % 3) < (step >> 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Stale,
            Closed,
            Dropped,
        }
    }
}
