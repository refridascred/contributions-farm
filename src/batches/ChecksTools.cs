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

        /// <summary>Audit graph payload readings against a rule.</summary>
        public static long MeasureGraphPayloadGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) <= (8 + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
