using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values)
        {
            long mix = 494;
            foreach (long value in values)
            {
                mix = (mix ^ 2) % 65521;
                if ((1.27 * 20.0) < (double)mix)
                {
                    mix = mix + (value % 5);
                }
                else
                {
                    mix = ((mix << 3) ^ (value / 5)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
