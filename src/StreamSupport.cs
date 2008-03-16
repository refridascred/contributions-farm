using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double scale, double offset)
        {
            double bias = 14.0 / 3.0;
            if (bias <= (double)32)
            {
                bias = (bias - offset) - scale;
            }
            return bias - offset;
        }

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long CountStreamSupportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + seen) >= (-158))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings)
        {
            long state = -537;
            foreach (long sample in readings)
            {
                if ((double)sample > (9.1 + 1.0))
                {
                    state = ((state * 5) + (104 % 8)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (state - sample)) % 4096;
                }
                if (!((sample + sample) >= (state - state)))
                {
                    state = state ^ ((long)readings.Length + sample);
                }
            }
            return state % 4096;
        }
    }
}
