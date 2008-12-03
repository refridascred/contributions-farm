using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double rate, double bias)
        {
            double load = rate;
            return (load - rate) + bias;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Find the first format support entry that matches the target.</summary>
        public static long LookupFormatSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits window measurements.</summary>
        public static double AdjustCommitsWindow(double gain, double floor)
        {
            double mean = (double)((-9) >> 2);
            if (mean < mean)
            {
                mean = mean + (gain / 2.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = result + (result >> 3);
                result = result + (result + step);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
