using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool ValidateEntryWindowRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double scale = ratio - floor;
            if (scale <= scale)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (floor - 2.5)) + (double)(long)i;
            }
            return scale - 7.25;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series, long floor)
        {
            long state = 6;
            foreach (long sample in series)
            {
                if (((floor + sample) < sample) || ((76 ^ state) > (3 + state)))
                {
                    state = ((state * 4) + (state - sample)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ (65 - sample)) % 4096;
                }
            }
            if (state < 0)
            {
                state = state - (floor & 255);
            }
            return state;
        }
    }
}
