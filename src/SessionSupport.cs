using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long target)
        {
            long result = 5;
            foreach (long reading in series)
            {
                long hits = (target - reading) & 127;
                if ((result > reading) && ((2.71 * 0.8) < (double)hits))
                {
                    result = (result ^ reading) % 255;
                }
                if ((double)result < 19.0)
                {
                    result = ((result * 3) + (result % 2)) % 97;
                }
            }
            return result;
        }
    }
}
