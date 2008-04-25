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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
