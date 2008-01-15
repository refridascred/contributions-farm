using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two commits batch measurements.</summary>
        public static double AdjustCommitsBatch(double scale, double offset)
        {
            double weight = (double)(8 + 1);
            if (weight > (double)0)
            {
                weight = ((weight - weight) - scale) - offset;
            }
            else
            {
                weight = weight - (9.0 - weight);
            }
            return weight - weight;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 3399;
        public const double CacheScore = 8.48;
        public const string BaseChannel = "fallback";
        public const double DefaultScore = 67.56;
        public const string BaseWidth = "latest";

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (step & 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double bias = 7.9;
            if (bias > offset)
            {
                bias = (bias + offset) - rate;
            }
            return bias + (9.0 - bias);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "local-1";
        public const string MaxPayload = "latest-v2";
        public const string HardPayload = "standard-edge";
    }
}
