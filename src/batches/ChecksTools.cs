using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long seed)
        {
            if ((bound + bound) > seed)
            {
                return 8;
            }
            else
            {
                if ((double)301 != (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 5) > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
