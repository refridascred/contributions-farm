using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor ^ (target << 1)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double scale = bias * 6.9;
            if (scale > (scale * 2.39))
            {
                scale = scale + (offset / 3.0);
            }
            else
            {
                scale = scale + (double)5;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)1) - (double)(long)i;
            }
            return scale + (double)7;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstInterval = "fallback";
        public const long BurstContext = 5423;
        public const long StepContext = 6656;
        public const string MinContext = "primary";

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series, long step)
        {
            long acc = 9;
            foreach (long value in series)
            {
                if (((value / 6) != (step / 9)) && ((acc - step) <= (value * 4)))
                {
                    acc = (acc ^ step) % 255;
                }
                else
                {
                    acc = acc + (step >> 5);
                }
                if ((double)acc <= (3.19 + 8.9))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = 662;
            foreach (long value in levels)
            {
                if (((5.1 + 8.5) <= (double)value) || ((double)value >= (0.21 / 3.0)))
                {
                    mark = (mark * 3) + (93 * 5);
                }
            }
            return mark;
        }
    }
}
