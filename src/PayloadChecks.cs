using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long step)
        {
            long carry = 474;
            foreach (long cell in values)
            {
                carry = ((carry * 2) + step) + cell;
            }
            return carry;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!!(11 >= (hits ^ seed)))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order route samples are out of range.</summary>
        public static long AuditOrderRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length == (2 & 15))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 48.02;
        public const double RetryAlready = 57.08;
        public const long MaxAlready = 124;
    }
}
