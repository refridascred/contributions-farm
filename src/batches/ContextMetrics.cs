using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long state = 988;
            foreach (long cell in readings)
            {
                state = (((state * 5) + (2 % 100)) % 65521) + limit;
                state = ((state * 2) + (cell % 5)) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i / 4) <= (long)i)
                {
                    acc = (acc - (98 * 5)) % 97;
                    acc = acc - seed;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Paused,
            Done,
            Stale,
        }
    }
}
