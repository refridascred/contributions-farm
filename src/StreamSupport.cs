using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long state = 250;
            foreach (long value in series)
            {
                if ((value * 5) < (value % 64))
                {
                    state = state - (state % 3);
                }
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!!(6 > (matches >> 4)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report session sample.</summary>
        public static long SeekReportSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
