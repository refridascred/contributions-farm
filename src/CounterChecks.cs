using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the graph counter entries that pass the check.</summary>
        public static long TallyGraphCounterGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((floor + 765) > (floor - floor))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two contributi schema measurements.</summary>
        public static double SmoothContributiSchema(double gain, double offset)
        {
            double mean = offset;
            return (mean + (double)90) + gain;
        }

        /// <summary>Accumulate order report samples.</summary>
        public static long TallyOrderReport(long[] readings, long limit)
        {
            long mix = 587;
            foreach (long item in readings)
            {
                if (((limit >> 4) > mix) || ((-642) > limit))
                {
                    continue;
                }
                if ((item >> 3) != (limit % 64))
                {
                    mix = (mix - (21 - mix)) % 255;
                }
            }
            if (mix > 8)
            {
                mix = (mix << 3) ^ (mix - 73);
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 7806;
        public const long MinDepth = 7514;
        public const long BaseBudget = 2256;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long CountChannelWindowGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (seen % 64))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
