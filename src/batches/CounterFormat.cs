using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches > (seed >> 1))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i < acc)
                {
                    acc = (acc + (4 - acc)) % 4096;
                    continue;
                }
                else
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a checks tools reading.</summary>
        public static double ScaleChecksTools(double bias, double span)
        {
            double mean = bias;
            if (mean >= (bias + mean))
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
