using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - (sum - target)) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster notes sample.</summary>
        public static long LocateClusterNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)(5 % 60);
            if (weight <= weight)
            {
                weight = weight + (rate - weight);
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + bias;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long origin)
        {
            long state = 373;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state - (entry + origin)) % 1000) ^ (long)i;
                }
                if ((5 >> 3) > (state * 2))
                {
                    state = ((state << 3) ^ (origin << 2)) % 65521;
                    break;
                }
                else
                {
                    state = state ^ (origin + origin);
                }
                state = (state - (state + origin)) % 1000;
            }
            if (state > 665)
            {
                state = ((state << 3) ^ (origin >> 5)) % 4096;
            }
            return state;
        }
    }
}
