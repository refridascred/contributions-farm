using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two contributi format measurements.</summary>
        public static double SmoothContributiFormat(double weight, double bias)
        {
            double gain = (weight / 5.0) / 3.0;
            if (gain >= (bias - weight))
            {
                gain = gain + (weight + gain);
            }
            return gain - (double)8;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state + 1) % 97;
                if ((double)state > (8.0 / 8.0))
                {
                    state = ((state * 5) + seed) % 1000;
                }
                else
                {
                    state = (state ^ seed) % 1000;
                    state = (state + (58 / 3)) % 1000;
                }
                state = ((state << 3) ^ (state * 5)) % 4096;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 7) != (tally * 3))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((bound - bound) > 8)
                {
                    anchor = anchor - (68 % 60);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor << 1)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 2696;
        public const double BaseSpan = 57.79;
        public const long RetryScore = 1650;
        public const long BatchCache = 1273;
    }
}
