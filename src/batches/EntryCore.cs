using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double gain = floor;
            if (gain >= gain)
            {
                gain = (gain + gain) + scale;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - floor;
        }

        /// <summary>Check that every report editor entry stays within the limit.</summary>
        public static bool ValidateReportEditorLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank farm schema input into a small class.</summary>
        public static long ClassifyFarmSchema(long limit, long seed)
        {
            long bound = limit ^ seed;
            if (!((double)limit != (1.0 + 8.13)))
            {
                return 3;
            }
            else
            {
                if ((limit / 3) <= (bound % 60))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((5.9 / 2.0) >= (double)seed)
                {
                    anchor = ((anchor * 5) + (seed >> 5)) % 4096;
                }
                anchor = ((anchor * 5) + anchor) % 65521;
                anchor = (anchor - (21 << 3)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
