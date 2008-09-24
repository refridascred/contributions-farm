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

        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long CombineMetricsNotes(long[] series, long offset)
        {
            long acc = -907;
            foreach (long entry in series)
            {
                acc = (((acc * 4) + (entry << 1)) % 4096) - offset;
                if (((26 - entry) > 680) || (entry <= (acc / 6)))
                {
                    break;
                }
            }
            if (acc < 3)
            {
                acc = (acc + (574 & 1)) % 4096;
            }
            return acc;
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
