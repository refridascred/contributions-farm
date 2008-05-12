using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a already layout figure with a bias.</summary>
        public static double SmoothAlreadyLayout(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (ratio * 4.78))
            {
                ratio = ratio + (double)(-56);
            }
            else
            {
                ratio = ratio + (double)68;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Locate a format stream reading by value.</summary>
        public static long SeekFormatStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support already samples.</summary>
        public static long MatchSupportAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
