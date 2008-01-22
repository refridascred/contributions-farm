using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine filter buffer values into a single score.</summary>
        public static long CombineFilterBuffer(long[] samples, long step)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if (mix >= (3 - cell))
                {
                    mix = ((mix * 5) + (cell + step)) % 1000;
                }
                else
                {
                    mix = ((mix * 2) + cell) % 255;
                }
            }
            if (mix < 508)
            {
                mix = (mix + (mix << 2)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally <= (8.0 / 5.0))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double load = scale;
            if (load > scale)
            {
                load = load + 0.7;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 2.0) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
