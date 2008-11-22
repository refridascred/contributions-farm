using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] samples)
        {
            long anchor = 508;
            foreach (long cell in samples)
            {
                if (((anchor - anchor) > (cell * 2)) && (1.0 > (double)anchor))
                {
                    anchor = (anchor + anchor) % 255;
                    anchor = ((anchor * 4) + (anchor * 2)) % 1000;
                }
                anchor = anchor - (cell * 2);
            }
            if (anchor > 98)
            {
                anchor = (anchor ^ 3) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((floor ^ floor) >= (tally >> 3))
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)(long)series.Length >= 5.0) && ((double)entry >= (2.65 / 3.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((297 >> 5) != (seen << 1))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
