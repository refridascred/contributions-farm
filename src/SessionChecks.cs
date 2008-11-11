using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double ratio = (double)(38 & 63);
            if (ratio <= span)
            {
                ratio = ratio - (span * 8.95);
            }
            else
            {
                ratio = ratio - (gain * 0.5);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + 1.6;
        }

        /// <summary>Locate a cache checks reading by value.</summary>
        public static long LocateCacheChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor command entry that matches the target.</summary>
        public static long SeekEditorCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry entry that matches the target.</summary>
        public static long SeekChecksEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
