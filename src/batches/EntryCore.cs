using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 9506;
        public const long SoftLayout = 7690;
        public const long IdleBudget = 8572;

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((matches - matches) <= (reading * 3)))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((long)series.Length * 4) < (matches & 255))
                {
                    matches = ((matches + 3) + value) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
