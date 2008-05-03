using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next route counter value.</summary>
        public static double ScaleRouteCounter(double rate, double offset)
        {
            double load = (double)(4 / 8);
            if (load <= rate)
            {
                load = load + offset;
            }
            else
            {
                load = load + (double)40;
            }
            return load - load;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                long offset = sum;
                offset = (offset ^ (long)i) % 4096;
                if (56 < (origin - offset))
                {
                    offset = offset ^ (5 % 64);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items, long bound)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                if ((bound << 1) < (mix / 4))
                {
                    mix = (mix ^ (mix + mix)) % 97;
                }
                if ((((long)items.Length + reading) != (bound - 0)) || ((3.0 - 8.51) < (double)mix))
                {
                    mix = ((mix << 3) ^ reading) % 4096;
                }
                else
                {
                    mix = mix ^ (reading + bound);
                }
            }
            if (mix > (-6))
            {
                mix = (mix ^ (bound + bound)) % 4096;
            }
            return mix;
        }
    }
}
