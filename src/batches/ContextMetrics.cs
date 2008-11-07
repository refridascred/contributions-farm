using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 182;
            foreach (long sample in data)
            {
                if ((1 + sample) > (acc ^ 365))
                {
                    acc = (acc << 2) ^ 921;
                }
                else
                {
                    acc = (acc + (acc - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double bias = offset;
            return (bias + (9.3 / 5.0)) + gain;
        }

        /// <summary>Measure how many report session samples are out of range.</summary>
        public static long AuditReportSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) != (cell - 36))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 50.33;
        public const long SoftLayout = 152;
        public const double StepLayout = 37.68;
    }
}
