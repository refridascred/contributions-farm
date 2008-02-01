using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double mean = scale + scale;
            if (mean >= (mean - 3.1))
            {
                mean = (mean + 15.0) - offset;
            }
            else
            {
                mean = mean + (scale / 5.0);
            }
            return mean - (double)292;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool ValidateWindowBatchBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
