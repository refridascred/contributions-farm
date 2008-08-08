using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + (carry + entry)) % 65521) + (long)i;
                }
                if ((double)carry < (double)entry)
                {
                    carry = (carry + (entry << 2)) % 4096;
                }
            }
            if (carry < (-295))
            {
                carry = (carry - carry) % 101;
            }
            return carry;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double load = (double)(684 - 5);
            if (load <= (load + load))
            {
                load = (load + (double)112) + floor;
            }
            return load + (ratio * 7.95);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Retry,
            Synced,
            Active,
            Closed,
        }
    }
}
