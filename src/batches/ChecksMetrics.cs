using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long seed)
        {
            long delta = step + seed;
            if (((2.5 + 1.4) != (double)seed) || ((seed % 5) > (90 + 418)))
            {
                return 0;
            }
            else
            {
                if (seed >= (step ^ 155))
                {
                    return 3;
                }
                else
                {
                    if (1 >= (step * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed - step) > delta)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double scale = (double)(7 + 61);
            if (scale > (double)162)
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale - (offset + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (8.0 + rate)) + (double)(long)i;
            }
            return scale - (scale - rate);
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double floor)
        {
            double mean = 7.61;
            if (mean < 14.0)
            {
                mean = ((mean - mean) - ratio) - floor;
            }
            return mean - (double)53;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
