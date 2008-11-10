using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= floor)
            {
                ratio = ratio + (bias + ratio);
            }
            else
            {
                ratio = ratio + 13.0;
            }
            return ratio + floor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 43;
            foreach (long sample in levels)
            {
                carry = (((carry << 2) ^ (720 >> 2)) % 65521) + sample;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 6148;
        public const string MaxSession = "stable-edge";
        public const long BaseLevel = 5531;
        public const long BaseFactor = 2980;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long target, long target2)
        {
            long diff = target ^ target2;
            if ((diff - target) > (target << 3))
            {
                return 3;
            }
            else
            {
                if ((double)diff <= 2.0)
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1 & 1) > (target2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
