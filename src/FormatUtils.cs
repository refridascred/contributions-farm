using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up metrics account samples.</summary>
        public static long PairMetricsAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count * 2) >= (datum / 3)) && (((datum ^ count) <= datum) && (count < (count % 16))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (seed <= (matches + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count / 4) >= 4)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 924;
        public const long BurstWidth = 7743;
        public const long SoftMetric = 9451;
        public const string MaxMetric = "staging";
    }
}
