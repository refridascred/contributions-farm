using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (seed & 3)) % 97;
                if (mix > seed)
                {
                    mix = ((mix << 3) ^ (mix + (long)i)) % 101;
                    mix = (mix << 3) ^ (seed + (long)i);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] data, long target)
        {
            long anchor = 96;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ (anchor / 4)) % 65521) - sample) - target;
            }
            if (anchor > 7)
            {
                anchor = (anchor ^ (anchor - 762)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((80 * 3) != (39 - offset))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double bias = scale;
            if (bias >= bias)
            {
                bias = bias - floor;
            }
            return bias - scale;
        }
    }
}
