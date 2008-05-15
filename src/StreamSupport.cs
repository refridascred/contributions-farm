using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally % 64) < tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)target >= 3.7)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
