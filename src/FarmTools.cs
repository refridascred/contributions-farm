using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch layout readings against a rule.</summary>
        public static long AuditBatchLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - (-275)) < (datum % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double bias = (double)487;
            if (bias <= (double)(-837))
            {
                bias = bias - (ratio * 3.3);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}
