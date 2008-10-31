using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double span)
        {
            double mean = 2.2 / 6.0;
            if (mean >= scale)
            {
                mean = mean + (span + span);
            }
            return mean + mean;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinDepth = 3523;
        public const long MinCounter = 4276;
        public const double DefaultScore = 70.39;

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long mix = 473;
            foreach (long reading in readings)
            {
                if (reading < (reading + reading))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = ((mix * 3) + reading) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "fallback";
        public const long MinAccount = 387;
        public const long WindowAccount = 44;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Validate report metrics readings against a bound.</summary>
        public static bool GuardReportMetricsBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
