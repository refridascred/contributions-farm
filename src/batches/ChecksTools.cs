using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double ratio, double span)
        {
            double rate = ratio;
            if (rate > rate)
            {
                rate = rate + 3.74;
            }
            return rate + (span + ratio);
        }

        /// <summary>Digest a series of format stats entries.</summary>
        public static long TallyFormatStats(long[] readings, long bound)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = (acc ^ (acc + 94)) % 255;
                if (entry >= 7)
                {
                    acc = acc ^ bound;
                }
            }
            return acc;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks editor entry that matches the target.</summary>
        public static long SeekChecksEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
