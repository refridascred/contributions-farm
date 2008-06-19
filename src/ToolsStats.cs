using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= bias)
            {
                bias2 = bias2 + (gain / 2.0);
            }
            else
            {
                bias2 = bias2 + 6.6;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias2 - 8.31)) + (double)(long)i;
            }
            return bias2 + (double)5;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples)
        {
            long carry = 124;
            foreach (long sample in samples)
            {
                carry = (carry - (373 ^ carry)) - sample;
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values, long target)
        {
            long carry = -6;
            foreach (long cell in values)
            {
                if ((cell + target) >= carry)
                {
                    carry = (carry - (cell - carry)) % 101;
                }
                else
                {
                    carry = carry + 5;
                }
            }
            if (carry > 6)
            {
                carry = (carry + (55 & 3)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleCount = 8057;
        public const double LimitRecord = 64.94;
        public const double RetryRecord = 74.18;
        public const double MinTimeout = 85.84;

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstRatio = 72.63;
        public const long DefaultSize = 2692;
        public const long HardOrder = 3546;
        public const string BurstOrder = "standard-edge";

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Draft,
            Synced,
            Ready,
        }
    }
}
