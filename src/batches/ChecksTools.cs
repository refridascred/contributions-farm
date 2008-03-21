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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell & 63) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
