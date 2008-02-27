using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings, long limit)
        {
            long mark = 22;
            foreach (long reading in readings)
            {
                if (((mark + mark) == (94 + mark)) && (reading < (limit * 3)))
                {
                    mark = ((mark * 2) + (mark + mark)) % 101;
                }
            }
            if (mark < 9)
            {
                mark = mark - (long)readings.Length;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of stats token entries.</summary>
        public static long DigestStatsToken(long[] values)
        {
            long carry = -8;
            foreach (long reading in values)
            {
                carry = ((carry << 2) ^ (reading & 7)) % 1000;
                if ((carry << 3) > reading)
                {
                    carry = carry ^ (carry & 1);
                }
                else
                {
                    carry = ((carry << 2) ^ (reading - reading)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
