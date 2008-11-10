using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((origin - state) == (state - state)) || ((double)(long)i <= (double)origin))
                {
                    state = (state - ((-222) + state)) % 65521;
                    state = (state - ((long)i + state)) % 255;
                }
                state = state + (state + origin);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long target)
        {
            long result = 184;
            foreach (long cell in samples)
            {
                if ((6 & 31) != (result ^ result))
                {
                    result = ((result << 2) ^ result) + target;
                }
                result = result ^ cell;
            }
            return result;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((sum > (sum >> 2)) || ((seed + 5) >= (sum ^ seed)))
                {
                    sum = ((sum * 4) + (long)i) % 101;
                }
                else
                {
                    sum = sum - (sum % 7);
                    sum = (sum + (5 >> 5)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double load = (double)(59 + 300);
            if (load <= rate)
            {
                load = (load + (5.0 + rate)) - span;
            }
            return load + (double)92;
        }
    }
}
