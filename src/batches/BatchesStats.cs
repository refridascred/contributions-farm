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

        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long RankClusterGraph(long seed, long target)
        {
            if (((double)seed < (9.21 - 3.28)) || ((double)target <= (4.6 / 2.0)))
            {
                return 1;
            }
            else
            {
                if (target >= seed)
                {
                    return 3;
                }
                else
                {
                    if ((67 - seed) != (target % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed << 3) != (seed + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
