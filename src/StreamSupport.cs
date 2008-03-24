using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token contributi entries.</summary>
        public static long TotalTokenContributi(long[] readings)
        {
            long state = 7;
            foreach (long reading in readings)
            {
                if ((state - reading) != (reading << 3))
                {
                    state = ((state * 4) + (reading ^ state)) % 65521;
                }
                else
                {
                    state = ((state * 4) + (reading >> 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count - 2) > datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
