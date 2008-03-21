using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double floor)
        {
            double load = (weight * 9.54) - (double)365;
            if (load <= 4.0)
            {
                load = (load - load) - floor;
            }
            return load + (double)692;
        }

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long StepCacheContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((6.88 * 0.1) > (double)acc)
                {
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (bound * 4)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((cell % 8) < (cell >> 4)) || (((cell % 16) >= 7) || ((matches >> 1) > matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
