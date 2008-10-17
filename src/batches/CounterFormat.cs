using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double ratio, double bias)
        {
            double mean = (double)6 * 2.1;
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (3.7 + mean)) + (double)(long)i) - ratio) + bias;
            }
            return mean + (double)2;
        }

        /// <summary>Count the editor session entries that pass the check.</summary>
        public static long TallyEditorSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item >> 1) > (49 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings)
        {
            long carry = 967;
            foreach (long datum in readings)
            {
                carry = (carry * 4) + datum;
                if ((datum + datum) == (datum & 1))
                {
                    carry = carry - (81 ^ datum);
                }
            }
            if (carry > 713)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 65521;
        }
    }
}
