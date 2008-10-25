using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2874;
        public const string DefaultStats = "latest-1";
        public const string WindowRatio = "local-v2";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long result = 865;
            foreach (long cell in values)
            {
                result = (result * 5) + (cell + result);
                if ((0.7 / 4.0) != (double)cell)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 32.46;
        public const string BaseSize = "cached-edge";
        public const string HardInterval = "primary-v2";

        /// <summary>Adjust a order notes reading.</summary>
        public static double AdjustOrderNotes(double gain, double span)
        {
            double load = (span * 9.13) / 9.0;
            if (load < gain)
            {
                load = load + (double)5;
            }
            return load + (double)396;
        }
    }
}
