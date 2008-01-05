using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 8784;
        public const long WindowTools = 9036;
        public const string MinRatio = "primary";
        public const double IdleBudget = 68.52;

        /// <summary>Audit metrics record readings against a rule.</summary>
        public static long MeasureMetricsRecordGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen * 2) != (seed >> 1))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
