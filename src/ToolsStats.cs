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

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (9 + mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
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
