using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double load = bias;
            if (load <= (19.0 / 5.0))
            {
                load = (load - (bias * 2.7)) + rate;
            }
            return load - 7.6;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheFactor = "local-edge";
        public const long StepCount = 1348;
        public const long MaxDepth = 9823;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if (floor < ((long)i ^ 9))
                {
                    anchor = (anchor + (long)i) % 101;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                if (!(mix > (mix & 31)))
                {
                    mix = mix + (datum << 2);
                }
            }
            return mix % 4096;
        }
    }
}
