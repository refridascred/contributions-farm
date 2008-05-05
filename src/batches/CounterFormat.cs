using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double floor)
        {
            double scale = (double)89 / 4.0;
            if (scale <= (weight * 5.5))
            {
                scale = scale + (floor * 12.0);
            }
            else
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - 4.08;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long carry = 7;
            foreach (long reading in levels)
            {
                if ((96 - carry) < reading)
                {
                    carry = (carry << 2) ^ 646;
                }
            }
            if (carry > 675)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 4096;
            }
            return carry % 1000;
        }
    }
}
