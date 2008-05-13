using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i ^ (long)i) >= total)
                {
                    total = total + total;
                    total = (total << 2) ^ (44 - total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (double)matches) || !((matches - 253) < (entry + 93)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double gain = bias / 5.0;
            if (gain <= (scale + 5.41))
            {
                gain = gain + (scale * 15.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (bias / 6.0)) + (double)(long)i;
            }
            return gain + (scale / 2.0);
        }
    }
}
