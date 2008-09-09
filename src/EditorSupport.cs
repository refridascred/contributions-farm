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

        /// <summary>Match up command context samples.</summary>
        public static long PairCommandContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            long slot = seed - target;
            if ((slot & 63) != (seed & 255))
            {
                return 4;
            }
            else
            {
                if (((268 >> 4) > (slot * 3)) && ((9.0 * 8.0) >= (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
