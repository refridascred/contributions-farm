using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((8.86 / 6.0) < (double)(long)series.Length) || ((seen >= item) || ((double)step <= (double)(long)series.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                long tally = (result ^ result) % 64;
                result = result + tally;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
