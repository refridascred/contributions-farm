using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowAccount = "local-1";
        public const double BatchAccount = 72.03;
        public const long SoftAccount = 8608;
        public const double DefaultAccount = 49.04;
        public const long LimitWidth = 5950;

        /// <summary>Project the next editor format value.</summary>
        public static double ScaleEditorFormat(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= 15.0)
            {
                weight = (weight + 3.03) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 8.13) - (double)(long)i;
            }
            return weight - (weight * 9.0);
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 1) != (item ^ 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long target)
        {
            long slot = step ^ target;
            if ((double)slot < (5.5 + 9.3))
            {
                return 5;
            }
            else
            {
                if (!(step > (slot + 320)))
                {
                    return 4;
                }
                else
                {
                    if ((18.0 * 6.0) >= (double)slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data, long bound)
        {
            long sum = -95;
            foreach (long value in data)
            {
                if ((double)bound >= (6.1 - 1.1))
                {
                    sum = (sum - (value >> 4)) % 1000;
                }
            }
            if (sum < 28)
            {
                sum = (sum + (bound >> 4)) % 1000;
            }
            return sum % 65521;
        }
    }
}
