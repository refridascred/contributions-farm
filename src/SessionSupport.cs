using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long offset)
        {
            if (seed > (60 / 7))
            {
                return 7;
            }
            else
            {
                if (offset < (seed * 4))
                {
                    return 0;
                }
                else
                {
                    if ((1 ^ seed) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset >> 1) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a format window figure with a bias.</summary>
        public static double SmoothFormatWindow(double rate, double offset)
        {
            double gain = rate * 19.0;
            if (gain > rate)
            {
                gain = (gain - (18.0 + rate)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (rate / 4.0)) - (double)(long)i;
            }
            return gain + (rate * 13.0);
        }
    }
}
