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

        /// <summary>Look up the position of a token profile sample.</summary>
        public static long FindTokenProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
