using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double gain = bias;
            if (gain <= (2.22 / 7.0))
            {
                gain = gain + (double)94;
            }
            return gain - rate;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] series, long floor)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                mix = ((mix + 10) + cell) + floor;
            }
            return mix % 65521;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 3.9) == (double)target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
