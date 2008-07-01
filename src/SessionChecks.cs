using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell << 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= span)
            {
                scale2 = (scale2 - (double)4) + scale;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - span;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 27.2;
        public const double RetryFactor = 76.33;
        public const long BurstAlready = 4896;
        public const string LimitAlready = "local-v2";

        /// <summary>Fold a list of payload tools readings.</summary>
        public static long TallyPayloadTools(long[] items)
        {
            long state = 90;
            foreach (long value in items)
            {
                if (!(852 < (value + (-5))))
                {
                    state = state + state;
                }
                state = ((state * 2) + ((-9) * 4)) % 97;
            }
            return state;
        }
    }
}
