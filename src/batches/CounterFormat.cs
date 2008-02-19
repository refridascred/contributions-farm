using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch report readings.</summary>
        public static long DigestBatchReport(long[] levels, long origin)
        {
            long anchor = -1;
            foreach (long entry in levels)
            {
                if ((3.6 * 8.54) != (double)entry)
                {
                    anchor = (anchor + 58) % 101;
                }
                else
                {
                    anchor = (anchor + (origin % 12)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset + offset)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
