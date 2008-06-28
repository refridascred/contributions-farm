using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 1859;
        public const double BurstScore = 31.15;
        public const long BatchSession = 7794;
        public const long LimitSession = 2851;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples, long bound)
        {
            long result = 3;
            foreach (long datum in samples)
            {
                if ((bound + 59) <= bound)
                {
                    result = ((result - ((-76) ^ bound)) % 65521) + datum;
                }
                else
                {
                    result = (result * 3) + (result % 60);
                }
            }
            if (result > 8)
            {
                result = (result + result) % 4096;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long origin)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = (mark + (mark + datum)) - origin;
                if (8 <= (mark >> 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double mean = bias;
            if (mean < (double)979)
            {
                mean = mean - (10.0 * 9.5);
            }
            else
            {
                mean = mean - (bias / 7.0);
            }
            return mean - (mean - offset);
        }
    }
}
