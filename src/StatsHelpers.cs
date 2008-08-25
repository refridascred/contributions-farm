using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long diff = step ^ seed;
            if ((0 % 3) != (step % 16))
            {
                return 5;
            }
            else
            {
                if (seed > (39 + 85))
                {
                    return 1;
                }
                else
                {
                    if (!((double)seed > (double)diff))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data, long origin)
        {
            long acc = 21;
            foreach (long datum in data)
            {
                acc = ((acc ^ acc) - datum) - origin;
            }
            return acc;
        }

        /// <summary>Fold a list of account session readings.</summary>
        public static long CombineAccountSession(long[] samples)
        {
            long acc = 634;
            foreach (long datum in samples)
            {
                acc = acc ^ (datum + acc);
            }
            return acc;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double bias, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + bias;
            }
            return gain + (gain * 20.0);
        }
    }
}
