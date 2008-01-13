using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(tally > (reading + (long)values.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit commits order readings against a rule.</summary>
        public static long TallyCommitsOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally * 5) <= (278 / 4)) || ((datum & 63) == (datum + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
