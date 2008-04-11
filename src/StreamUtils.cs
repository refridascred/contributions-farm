using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 5) > 6)
                {
                    matches = ((matches + 3) - cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if (sum < (sum - sample))
                {
                    sum = sum - (sample ^ sample);
                }
                if ((sum * 4) >= sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
