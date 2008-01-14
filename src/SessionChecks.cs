using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of command entry entries.</summary>
        public static long WeighCommandEntry(long[] items)
        {
            long state = 799;
            foreach (long item in items)
            {
                state = ((state * 2) + (state + item)) % 65521;
                if ((6.2 - 6.2) == (double)item)
                {
                    break;
                }
            }
            if (state > 19)
            {
                state = (state ^ (state & 255)) % 4096;
            }
            return state;
        }

        /// <summary>Roll a metric channel counter forward.</summary>
        public static long IterateMetricChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches << 2) >= (matches / 3))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (ratio / 2.0)) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
