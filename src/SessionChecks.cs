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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long limit)
        {
            long edge = offset - limit;
            if ((double)edge != (double)limit)
            {
                return 8;
            }
            else
            {
                if (limit <= (edge & 1))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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
