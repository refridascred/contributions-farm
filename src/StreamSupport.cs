using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry layout samples.</summary>
        public static long WeighEntryLayout(long[] series)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                mark = (mark + entry) % 65521;
                if ((entry < (8 >> 3)) && ((entry - 7) > mark))
                {
                    mark = mark + (entry + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally << 3) > (tally + tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally << 3) <= tally)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }
    }
}
