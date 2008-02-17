using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a editor window figure with a bias.</summary>
        public static double ProjectEditorWindow(double scale, double bias)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = (weight + (double)31) - scale;
            }
            return weight - weight;
        }

        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long CountContributiCounterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 3) > (cell & 3)) || ((cell ^ cell) <= (cell - seen)))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series, long bound)
        {
            long total = 5;
            foreach (long reading in series)
            {
                if (!(total > 247))
                {
                    total = ((total * 2) + (bound + total)) + reading;
                }
                total = (total - (6 & 63)) % 1000;
            }
            return total;
        }
    }
}
