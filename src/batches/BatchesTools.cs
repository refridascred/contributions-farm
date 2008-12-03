using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long floor)
        {
            if (((bound & 63) < floor) && ((floor / 5) == (2 + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (12.0 + 13.0))
                {
                    return 8;
                }
                else
                {
                    if (!((floor % 60) < 12))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (15.0 + 19.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double ratio = rate + (span * 20.0);
            if (ratio <= 3.0)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
