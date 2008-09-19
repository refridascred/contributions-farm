using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double bias)
        {
            double load = rate;
            return (load - (double)1) + bias;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = (state - ((long)i ^ 484)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long offset)
        {
            long anchor = 46;
            foreach (long value in data)
            {
                if ((value << 2) < (4 + 471))
                {
                    anchor = (anchor - (value << 1)) % 97;
                }
                else
                {
                    anchor = (anchor + (offset + offset)) % 97;
                }
            }
            return anchor;
        }
    }
}
