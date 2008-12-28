using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double load = (double)(271 + 38);
            if (load >= (scale - 6.05))
            {
                load = (load - load) - bias;
            }
            return load - scale;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double scale = weight;
            if (scale > (weight + bias))
            {
                scale = scale - (7.82 / 7.0);
            }
            else
            {
                scale = scale - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale - (6.0 + scale);
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step * 5) >= step)
                {
                    result = ((result * 2) + (long)i) % 97;
                }
                if (!((result + (-852)) < (step ^ (long)i)))
                {
                    result = ((result * 4) + ((long)i - step)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((8.23 - 14.0) > (double)count) || (((value << 1) == (value + bound)) || ((count & 127) < count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
