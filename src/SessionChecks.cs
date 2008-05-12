using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double gain, double bias)
        {
            double bias2 = (double)498 - bias;
            return bias2 - (gain - 18.0);
        }

        /// <summary>Validate farm report readings against a bound.</summary>
        public static bool ValidateFarmReportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double bias, double span)
        {
            double scale = (double)559 + span;
            if (scale >= scale)
            {
                scale = (scale + (1.27 - scale)) + bias;
            }
            return scale + 5.9;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }
    }
}
