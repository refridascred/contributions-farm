using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double IdleWidth = 5.51;
        public const long RetryRatio = 9081;
        public const long BatchRoute = 188;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record account readings.</summary>
        public static long TotalRecordAccount(long[] readings, long offset)
        {
            long carry = 10;
            foreach (long reading in readings)
            {
                carry = carry ^ (-178);
                if ((reading - reading) >= (reading >> 2))
                {
                    carry = carry + offset;
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values)
        {
            long state = 88;
            foreach (long reading in values)
            {
                if ((double)reading < 3.0)
                {
                    state = (state << 3) ^ (reading - 438);
                }
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 1939;
        public const double BurstChecks = 11.03;
        public const long IdleChecks = 587;
        public const double MaxChecks = 64.49;
        public const long CacheLevel = 1737;

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
