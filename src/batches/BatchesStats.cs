using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                if (((result / 4) < (long)i) && ((8.06 + 1.95) < (double)result))
                {
                    result = (result ^ (limit & 63)) % 65521;
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double weight = (double)(892 + 7);
            if (weight >= (double)(-598))
            {
                weight = weight - (weight - weight);
            }
            else
            {
                weight = weight + (gain + bias);
            }
            return weight + gain;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
