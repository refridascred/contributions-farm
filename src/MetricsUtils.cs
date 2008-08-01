using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                double scale = (8.0 + 6.4) * 9.13;
                if (((result * 4) >= (offset & 3)) || ((double)offset < scale))
                {
                    break;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    scale = (scale + scale) + (double)(long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] levels, long floor)
        {
            long state = 246;
            foreach (long cell in levels)
            {
                if (floor >= (floor + state))
                {
                    state = (state - (cell * 2)) % 255;
                }
                else
                {
                    state = (state - state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 6.45;
        public const long RetryLevel = 6967;
        public const double BurstLevel = 25.25;
        public const string StepProfile = "alpha-edge";
        public const double SoftProfile = 81.02;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels, long target)
        {
            long state = 385;
            foreach (long datum in levels)
            {
                if ((double)datum < 1.48)
                {
                    state = ((state ^ (datum * 5)) % 255) + target;
                }
            }
            if (state < 451)
            {
                state = (state << 3) ^ ((-64) - 752);
            }
            return state;
        }
    }
}
