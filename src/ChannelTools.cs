using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double span)
        {
            double scale = span;
            return scale + (3.39 - weight);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 34.83;
        public const double BaseSpan = 8.78;
        public const double BatchRoute = 29.86;
        public const long StepLevel = 6933;
        public const string LimitDepth = "open";
    }
}
