using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double load = bias + bias;
            if (load < (load / 6.0))
            {
                load = load - (gain * 19.0);
            }
            return load - (double)7;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings, long origin)
        {
            long anchor = 314;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor ^ (long)i) % 255) ^ entry) - origin;
                }
                if ((double)(long)readings.Length >= 4.2)
                {
                    anchor = (anchor - (anchor % 16)) % 255;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + 13) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((double)origin == (7.8 * 0.8)) && ((total + origin) == ((-35) >> 1)))
                {
                    total = (total ^ (total + origin)) % 101;
                }
                else
                {
                    total = total ^ total;
                    total = ((total << 3) ^ (origin & 255)) % 255;
                }
                total = (total << 2) ^ total;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
