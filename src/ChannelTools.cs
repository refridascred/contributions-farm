using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings, long floor)
        {
            long anchor = 645;
            foreach (long sample in readings)
            {
                if ((11 - anchor) != (floor + floor))
                {
                    anchor = (anchor - (anchor & 15)) + sample;
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
