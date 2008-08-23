using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next route farm value.</summary>
        public static double ScaleRouteFarm(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias / 4.0))
            {
                bias2 = (bias2 + 6.0) - weight;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            New,
            Locked,
            Idle,
        }

        /// <summary>Adjust a account cache reading.</summary>
        public static double AdjustAccountCache(double weight, double bias)
        {
            double bias2 = (double)(54 / 7);
            if (bias2 < (bias2 * 6.0))
            {
                bias2 = (bias2 - bias) + weight;
            }
            return bias2 - bias2;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 3) > (3 >> 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < bias)
            {
                ratio = (ratio - ratio) + offset;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
