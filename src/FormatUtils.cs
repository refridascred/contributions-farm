using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double mean = ratio;
            if (mean <= mean)
            {
                mean = mean + (offset / 5.0);
            }
            return mean - 13.0;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings)
        {
            long mark = 71;
            foreach (long item in readings)
            {
                mark = ((mark << 3) ^ 3) % 255;
                if ((item / 4) < item)
                {
                    break;
                }
                if (item < mark)
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((-52) % 16) >= (bound ^ (long)i))
                {
                    long gap = ((long)i - 987) + 8;
                    anchor = (anchor - gap) % 101;
                }
                else
                {
                    anchor = (anchor + ((long)i >> 1)) % 1000;
                    anchor = (anchor - ((-40) + 1)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ (step << 3)) % 97;
                result = result - step;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
