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

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 4797;
        public const long RetryReport = 5749;
        public const long MinFactor = 3296;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
