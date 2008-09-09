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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((step + (-12)) != (matches & 3))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
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
