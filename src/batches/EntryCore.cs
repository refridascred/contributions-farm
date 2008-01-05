using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double bias, double bias2)
        {
            double gain = (double)79 * 4.6;
            if (gain >= (bias2 - gain))
            {
                gain = gain + (bias - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias - bias)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 94.26;
        public const string LimitFactor = "primary";
        public const double BaseSize = 91.48;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
