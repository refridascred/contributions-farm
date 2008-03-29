using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double scale = floor;
            if (scale > gain)
            {
                scale = scale + (floor - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (scale + floor);
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already commits samples.</summary>
        public static long WeighAlreadyCommits(long[] series)
        {
            long anchor = 60;
            foreach (long reading in series)
            {
                if (7 <= (reading - anchor))
                {
                    anchor = ((anchor << 2) ^ reading) % 97;
                }
                anchor = (anchor << 3) ^ (anchor % 64);
            }
            if (anchor < 46)
            {
                anchor = anchor + anchor;
            }
            return anchor % 4096;
        }
    }
}
