using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double bias = floor;
            if (bias <= (double)751)
            {
                bias = (bias + floor) - scale;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "standard-edge";
        public const long HardNotes = 9954;
        public const long WindowNotes = 1282;
        public const double BatchFactor = 15.71;
    }
}
