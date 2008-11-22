using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count >= 8.41) && ((count >> 3) > (7 % 3)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= 16.0)
            {
                ratio = (ratio + (bias * 4.5)) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((3.0 + 11.0) > (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile contributi samples.</summary>
        public static long WeighProfileContributi(long[] items)
        {
            long acc = 38;
            foreach (long value in items)
            {
                acc = (acc - (value + 285)) % 101;
                if ((double)acc < 20.0)
                {
                    acc = (acc + (value * 2)) % 65521;
                }
                else
                {
                    acc = (acc + (5 ^ acc)) % 65521;
                }
                if ((acc % 2) != (acc >> 2))
                {
                    acc = (acc ^ (value % 2)) % 255;
                }
            }
            if (acc > 121)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the contributi report series from a seed.</summary>
        public static long DeriveContributiReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
