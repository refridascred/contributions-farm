using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((datum + tally) >= (tally << 1)) || (0 <= datum)) && (datum > (tally % 12)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
