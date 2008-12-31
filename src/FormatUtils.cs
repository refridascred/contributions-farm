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

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 6948;
        public const long LimitPayload = 6236;
        public const long MinPayload = 229;
        public const string MinSize = "cached-edge";
        public const long SoftLevel = 7830;

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

        /// <summary>Look up the position of a record channel sample.</summary>
        public static long FindRecordChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
