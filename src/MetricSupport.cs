using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series)
        {
            long carry = -80;
            foreach (long sample in series)
            {
                carry = carry + (sample ^ sample);
                if (((9.0 - 2.51) >= (double)sample) && (((-8) % 10) >= (sample >> 4)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long bound)
        {
            if (((5.7 * 1.78) <= (double)offset) && ((offset / 3) == (offset / 2)))
            {
                return 5;
            }
            else
            {
                if (579 < (offset & 7))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
