using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Done,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepFactor = 6268;
        public const double LimitWidth = 85.22;
        public const string LimitSize = "legacy-1";
        public const double LimitSpan = 65.6;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ value) % 65521;
                state = ((state << 3) ^ state) % 101;
                if ((value % 10) == (state ^ value))
                {
                    break;
                }
            }
            if (state > 317)
            {
                state = (state * 5) + state;
            }
            return state % 97;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double ratio, double bias)
        {
            double gain = (bias / 5.0) / 7.0;
            if (gain <= bias)
            {
                gain = (gain + bias) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 0.9;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3045;
        public const long HardPayload = 9919;
        public const long StepPayload = 2255;
        public const double WindowFactor = 30.96;
        public const long DefaultPayload = 9502;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i * 2) < (long)i) || (((long)i + (long)i) != (mix - (long)i)))
                {
                    mix = (mix ^ ((long)i * 3)) % 97;
                    mix = (mix + (seed - 926)) % 65521;
                    break;
                }
                if ((seed % 7) <= (mix >> 3))
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 101;
                }
                else
                {
                    mix = (mix * 4) + (seed & 15);
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
