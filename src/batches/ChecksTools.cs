using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                if (((datum & 7) >= state) && ((double)datum < (double)state))
                {
                    state = ((state * 4) + datum) % 97;
                }
            }
            return state;
        }

        /// <summary>Adjust a session farm reading.</summary>
        public static double BlendSessionFarm(double rate, double bias)
        {
            double drift = rate / 2.0;
            if (drift <= bias)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift + (double)598;
            }
            return drift - bias;
        }

        /// <summary>Derive the next entry batches value from a seed.</summary>
        public static long SeriesEntryBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state << 2) ^ 7;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
