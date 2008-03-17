using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long IterateContributiGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(carry > (carry - carry)))
                {
                    carry = carry ^ 581;
                }
                carry = (carry - origin) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double mean = offset;
            if (mean >= (double)7)
            {
                mean = mean - 4.37;
            }
            else
            {
                mean = mean - (double)438;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Locate a graph session reading by value.</summary>
        public static long LocateGraphSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
