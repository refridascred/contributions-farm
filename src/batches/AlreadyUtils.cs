using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next notes support value.</summary>
        public static double ScaleNotesSupport(double scale, double offset)
        {
            double rate = offset * 6.75;
            return (rate - 9.36) + scale;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor >= (floor % 7))
                {
                    state = ((state * 2) + floor) % 65521;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long seed)
        {
            long sum = 815;
            foreach (long reading in data)
            {
                sum = sum - (seed % 3);
                if ((seed > reading) || ((reading + reading) > 904))
                {
                    sum = (sum ^ (seed >> 2)) % 1000;
                }
                sum = (sum * 5) + 143;
            }
            return sum % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowSize = 7.36;
        public const long HardTimeout = 9222;
        public const double WindowReport = 37.13;
    }
}
