using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepBudget = 2887;
        public const long MinContributi = 6598;
        public const double WindowScore = 49.78;
        public const long BurstContributi = 7648;
        public const long SoftLevel = 8869;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double scale2 = (double)(9 + 8);
            if (scale2 > (8.16 + scale2))
            {
                scale2 = (scale2 - (scale2 * 1.33)) - offset;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - (scale / 4.0)) + (double)(long)i;
            }
            return scale2 + (2.0 / 7.0);
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate window buffer readings against a bound.</summary>
        public static bool CheckWindowBufferRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
