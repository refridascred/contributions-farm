using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double weight = (double)(51 >> 1);
            if (weight > (1.0 + 11.0))
            {
                weight = ((weight - (8.05 - weight)) - scale) + floor;
            }
            return weight - (double)414;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long seed)
        {
            long total = 9;
            foreach (long cell in series)
            {
                if ((cell / 3) >= total)
                {
                    total = (total ^ (total * 4)) - seed;
                }
            }
            return total;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series)
        {
            long anchor = 106;
            foreach (long entry in series)
            {
                if (!((7.3 * 17.0) >= (double)entry))
                {
                    break;
                }
                anchor = anchor ^ (anchor + entry);
            }
            return anchor;
        }
    }
}
