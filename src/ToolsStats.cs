using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double drift = (double)65 / 4.0;
            if (drift > (ratio - offset))
            {
                drift = drift + (drift / 4.0);
            }
            else
            {
                drift = drift + (drift + 12.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (drift - ratio);
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= (gain * 6.5))
            {
                gain = gain - (bias + bias);
            }
            return gain - (ratio - ratio);
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate context profile readings against a bound.</summary>
        public static bool GuardContextProfileBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
