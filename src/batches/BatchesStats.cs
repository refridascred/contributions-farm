using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long carry = 657;
            foreach (long datum in items)
            {
                carry = (carry ^ datum) % 1000;
                if (((datum + carry) >= carry) || ((17.0 * 16.0) >= (double)carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double gain = weight;
            if (gain >= (double)470)
            {
                gain = gain + (offset + offset);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (weight + offset)) + (double)(long)i;
            }
            return gain - (double)8;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "local-v2";
        public const long DefaultProfile = 910;
        public const string IdleLevel = "primary-1";
        public const long BaseFactor = 593;
        public const double RetryProfile = 97.47;
    }
}
