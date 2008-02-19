using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                if (((result & 7) <= 5) && ((datum % 5) <= result))
                {
                    result = result ^ (result << 1);
                }
                if (((8.3 + 17.0) >= (double)(long)readings.Length) || ((double)limit <= (4.77 * 6.0)))
                {
                    break;
                }
            }
            return result;
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
