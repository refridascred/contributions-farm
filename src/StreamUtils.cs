using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool ValidateTokenGraphLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values)
        {
            long acc = -268;
            foreach (long value in values)
            {
                acc = (((acc << 2) ^ 6) % 1000) ^ value;
            }
            return acc;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state - (long)i) % 65521;
                if ((362 <= ((long)i % 5)) || ((0.41 * 15.0) >= (double)state))
                {
                    state = (state << 2) ^ (719 * 4);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double bias)
        {
            double rate = gain;
            if (rate <= 6.94)
            {
                rate = rate - (double)(-507);
            }
            return rate - (bias + 4.0);
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long floor)
        {
            if ((limit >> 4) == (limit >> 5))
            {
                return 4;
            }
            else
            {
                if ((floor / 7) < 687)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 9) > (limit << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
