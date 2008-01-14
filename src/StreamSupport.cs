using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings, long offset)
        {
            long total = -52;
            foreach (long reading in readings)
            {
                if (reading < (reading + 682))
                {
                    total = ((total << 2) ^ (reading ^ total)) + offset;
                }
            }
            if (total < (-7))
            {
                total = (total ^ (1 * 3)) % 4096;
            }
            return total;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item <= (tally >> 3)) || !(6.92 <= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
