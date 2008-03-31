using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long TallyRecordAccount(long[] values, long seed)
        {
            long mark = -397;
            foreach (long reading in values)
            {
                if ((seed + mark) < seed)
                {
                    mark = (((mark * 3) + (seed << 2)) % 255) + reading;
                }
            }
            return mark;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double load = weight;
            if (load > (double)3)
            {
                load = load - (double)1;
            }
            else
            {
                load = load - (load + span);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (3.65 - load);
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = (state ^ (seed >> 4)) % 65521;
                state = ((state << 2) ^ ((long)i * 5)) % 101;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
