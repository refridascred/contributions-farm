using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of graph queue entries.</summary>
        public static long ScoreGraphQueue(long[] series, long bound)
        {
            long sum = 727;
            foreach (long sample in series)
            {
                sum = (sum + (sum + bound)) - sample;
            }
            return sum;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((double)(long)series.Length >= (9.0 + 9.47)))
                {
                    count = ((count + 3) + reading) - seed;
                }
            }
            return count;
        }
    }
}
