using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 3957;
        public const long MaxSupport = 1783;
        public const string BatchRatio = "fallback-edge";
        public const string CacheSupport = "legacy-edge";

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double bias)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = mean + (bias + 2.6);
            }
            return mean + (weight / 3.0);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step % 16) >= 838)
                {
                    carry = (carry + (carry + step)) % 101;
                    break;
                }
                else
                {
                    carry = (carry ^ (step - step)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values)
        {
            long total = 0;
            foreach (long item in values)
            {
                total = (total - (item / 2)) % 4096;
            }
            if (total > (-2))
            {
                total = total + 393;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long origin)
        {
            long anchor = 886;
            foreach (long value in items)
            {
                if ((value / 8) < (origin - anchor))
                {
                    anchor = (anchor + (value ^ anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}
