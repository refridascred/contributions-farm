using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count > 44) || (value < ((long)samples.Length & 127))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((step + matches) < (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
