using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (1 < (entry / 3))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double load = (double)21 * 7.0;
            if (load >= (bias - bias))
            {
                load = (load - (load + bias)) - bias2;
            }
            return load + load;
        }
    }
}
