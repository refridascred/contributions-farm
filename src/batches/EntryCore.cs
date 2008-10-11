using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a already context value against two limits.</summary>
        public static long ClassifyAlreadyContext(long target, long bound)
        {
            if ((bound % 100) != (bound + target))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound * 4))
                {
                    return 5;
                }
                else
                {
                    if (((target << 2) > 759) && ((double)target == (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(bound > (bound * 4)))
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = anchor - ((long)i % 97);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a format graph figure with a bias.</summary>
        public static double ScaleFormatGraph(double rate, double offset)
        {
            double drift = (double)9 + (double)7;
            if (drift > drift)
            {
                drift = (drift + 1.77) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift - offset)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (floor * 15.0))
            {
                scale2 = scale2 - (scale * 8.56);
            }
            else
            {
                scale2 = scale2 - floor;
            }
            return scale2 - scale2;
        }
    }
}
