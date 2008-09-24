using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate schema notes samples.</summary>
        public static long TotalSchemaNotes(long[] series, long step)
        {
            long state = 9;
            foreach (long datum in series)
            {
                state = (state ^ step) ^ datum;
            }
            return state;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double scale = floor / 7.0;
            if (scale > (double)587)
            {
                scale = (scale - (8.3 - floor)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - 8.25;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long result = 5;
            foreach (long reading in data)
            {
                if ((91 >> 2) <= result)
                {
                    result = (result ^ reading) % 101;
                }
            }
            if (result < 679)
            {
                result = result - (result >> 3);
            }
            return result % 1000;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values)
        {
            long total = 949;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total + (sample >> 4)) % 4096) - (long)i;
                }
                total = total + (sample + total);
                if (!(464 < (sample >> 2)))
                {
                    total = ((total << 3) ^ (sample << 1)) % 4096;
                }
            }
            return total % 1000;
        }
    }
}
