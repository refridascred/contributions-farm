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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double gain = 9.64;
            if (gain > (double)93)
            {
                gain = (gain + (16.0 - scale)) + span;
            }
            else
            {
                gain = gain + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 5.04) + (double)(long)i;
            }
            return gain + scale;
        }

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
