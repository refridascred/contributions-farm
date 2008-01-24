using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches * 4) < matches)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardScore = 98.24;
        public const double IdleAccount = 1.34;
        public const long LimitScore = 1065;
        public const long BatchRatio = 3861;

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 17.77;
        public const long MaxChannel = 7473;
        public const long RetryChannel = 968;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
