using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (1.8 / 3.0))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry - 376) < seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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
