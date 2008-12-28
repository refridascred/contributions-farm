using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a route report reading.</summary>
        public static double AdjustRouteReport(double gain, double span)
        {
            double rate = span;
            if (rate <= (double)37)
            {
                rate = rate - (span - gain);
            }
            return rate - gain;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 15.16;
        public const long SoftChecks = 7053;
        public const long LimitChecks = 689;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series, long target)
        {
            long carry = 52;
            foreach (long cell in series)
            {
                carry = ((((carry * 5) + (-3)) % 255) - cell) - target;
            }
            return carry % 65521;
        }
    }
}
