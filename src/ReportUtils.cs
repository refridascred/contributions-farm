using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                carry = ((carry * 4) + (carry - reading)) % 1000;
                carry = (carry + (8 + 4)) % 97;
            }
            if (carry < 4)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((9.1 * 6.8) > (double)item)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
