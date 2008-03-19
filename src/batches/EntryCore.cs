using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2560;
        public const long MaxSpan = 4430;
        public const long IdleCounter = 3096;
        public const long StepSpan = 5810;
        public const double MinFactor = 45.79;

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double bias = (weight * 3.7) * 7.42;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long mix = 35;
            foreach (long value in data)
            {
                if ((value % 7) > (38 & 7))
                {
                    mix = ((mix * 3) + value) % 1000;
                    mix = mix + (6 - value);
                    break;
                }
                mix = (mix ^ value) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((double)tally >= (7.72 + 1.42)))
                {
                    tally = ((tally + 1) + cell) + step;
                }
            }
            return tally;
        }
    }
}
