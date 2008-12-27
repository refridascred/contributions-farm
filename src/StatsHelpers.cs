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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((6 - sample) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a session farm reading.</summary>
        public static double ProjectSessionFarm(double scale, double bias)
        {
            double ratio = (double)(566 - 791);
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio + (scale + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 9.36) + (double)(long)i;
            }
            return ratio - (16.0 * 6.0);
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
