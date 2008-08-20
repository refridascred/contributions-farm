using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
