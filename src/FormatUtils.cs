using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "legacy-v2";
        public const long SoftContributi = 8551;
        public const long DefaultInterval = 2980;
        public const double RetrySize = 75.91;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((7.53 * 7.9) > (double)value) && ((double)origin >= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] values)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + mix) % 65521) - datum;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] items)
        {
            long carry = 51;
            foreach (long cell in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (carry ^ (cell - carry)) + (long)i;
                    carry = ((carry * 2) + (cell - carry)) % 4096;
                }
                if (!(6 < (carry - 106)))
                {
                    carry = ((carry * 2) + (carry ^ cell)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
