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

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
