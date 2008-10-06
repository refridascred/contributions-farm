using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a batch filter figure with a bias.</summary>
        public static double ScaleBatchFilter(double scale, double span)
        {
            double weight = (double)(300 >> 1);
            if (weight >= (weight / 9.0))
            {
                weight = (weight + (span / 2.0)) + scale;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + weight;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (75 & 7)) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ origin) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
