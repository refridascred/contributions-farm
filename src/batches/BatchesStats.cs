using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of payload graph readings.</summary>
        public static long CombinePayloadGraph(long[] values, long floor)
        {
            long state = 636;
            foreach (long cell in values)
            {
                if (((3 - floor) >= (cell - cell)) && ((12.0 * 7.9) == (double)cell))
                {
                    state = ((state << 3) ^ (cell ^ (long)values.Length)) % 65521;
                }
            }
            if (state < (-440))
            {
                state = (state + floor) % 1000;
            }
            return state;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long target, long seed)
        {
            if (2 >= target)
            {
                return 2;
            }
            else
            {
                if (!((seed / 3) > seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double scale = (double)(5 >> 1);
            if (scale <= scale)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + 4.48;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Failed,
            Retry,
        }
    }
}
