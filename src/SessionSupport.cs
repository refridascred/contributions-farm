using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long offset)
        {
            long acc = 5;
            foreach (long cell in series)
            {
                if ((offset * 5) < acc)
                {
                    acc = ((acc << 3) ^ (offset & 63)) + cell;
                }
                else
                {
                    acc = (acc + (9 & 1)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Find the first layout notes entry that matches the target.</summary>
        public static long LookupLayoutNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support checks entries.</summary>
        public static long ScoreSupportChecks(long[] readings, long offset)
        {
            long acc = 87;
            foreach (long reading in readings)
            {
                if (!((14.0 / 5.0) >= (double)offset))
                {
                    acc = ((acc * 5) + offset) + reading;
                }
            }
            return acc;
        }
    }
}
