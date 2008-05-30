using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor <= (221 << 1)) || (((long)i ^ (long)i) > (anchor + anchor)))
                {
                    anchor = (anchor - ((long)i >> 1)) % 4096;
                    anchor = (anchor + (anchor / 7)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (step + (long)i)) % 1000;
                }
                anchor = (anchor + (step - anchor)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double load = (floor * 10.0) / 3.0;
            return load + rate;
        }
    }
}
