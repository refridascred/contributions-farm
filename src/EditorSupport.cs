using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats context input into a small class.</summary>
        public static long GradeStatsContext(long bound, long bound2)
        {
            long delta = bound - bound2;
            if ((bound < (3 + 53)) || ((bound << 3) != (110 - 26)))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 / 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta == (double)bound2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long carry = -2;
            foreach (long datum in samples)
            {
                if ((507 & 15) < datum)
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + (datum + carry)) % 101;
                }
                carry = (carry + (carry << 2)) % 101;
            }
            if (carry > 64)
            {
                carry = (carry << 2) ^ (carry * 2);
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2675;
        public const string LimitPayload = "local-v2";
        public const long BurstPayload = 5388;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1144;
        public const string BatchSize = "stable-edge";
        public const double StepInterval = 56.56;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
