using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (4.5 / 4.0))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)count == (double)item) || !((item << 3) < (count - item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
