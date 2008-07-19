using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((value * 5) < 103) || ((tally / 9) == (value << 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double gain = (double)34 / 3.0;
            if (gain < (gain / 5.0))
            {
                gain = (gain - (1.0 / 7.0)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 1.9) + (double)(long)i;
            }
            return gain - (floor * 0.2);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally > (datum + 320))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
