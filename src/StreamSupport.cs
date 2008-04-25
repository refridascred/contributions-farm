using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double load = rate;
            if (load < (rate / 5.0))
            {
                load = load + rate;
            }
            else
            {
                load = load - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (rate * 3.0);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long mark = 825;
            foreach (long cell in items)
            {
                mark = ((mark << 2) ^ (cell & 63)) % 101;
                mark = (mark * 3) + 2;
            }
            if (mark < 48)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings, long bound)
        {
            long mark = -319;
            foreach (long reading in readings)
            {
                if (((1 + 60) <= bound) && (7.84 >= (double)bound))
                {
                    mark = ((mark + mark) % 97) - reading;
                }
            }
            if (mark < 8)
            {
                mark = ((mark * 3) + (bound ^ mark)) % 101;
            }
            return mark;
        }
    }
}
