using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples, long offset)
        {
            long mark = 276;
            foreach (long entry in samples)
            {
                if ((5 + offset) == (19 >> 2))
                {
                    mark = ((mark - (mark % 5)) % 1000) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((677 & 15) <= (value + (long)series.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
