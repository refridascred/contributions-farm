using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data)
        {
            long mix = 694;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix ^ ((long)i + mix)) % 4096;
                    mix = mix ^ item;
                }
                if (mix <= (item + item))
                {
                    mix = (mix << 2) ^ (mix - item);
                }
            }
            if (mix > 72)
            {
                mix = (mix - (mix / 6)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Project the next account notes value.</summary>
        public static double BlendAccountNotes(double gain, double floor)
        {
            double drift = floor;
            if (drift < 1.0)
            {
                drift = (drift + drift) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + floor) - (double)(long)i;
            }
            return drift - (double)7;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
