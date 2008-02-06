using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double rate = span;
            if (rate <= 7.43)
            {
                rate = (rate - (rate / 5.0)) + gain;
            }
            return rate + (double)54;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardScore = "alpha-1";
        public const long BatchRatio = 7614;
        public const string MaxFactor = "legacy-v2";
        public const long WindowToken = 4885;

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] values, long floor)
        {
            long carry = 30;
            foreach (long reading in values)
            {
                if ((floor + floor) != (reading + carry))
                {
                    carry = carry - (carry / 9);
                }
                if ((double)carry >= 20.0)
                {
                    break;
                }
            }
            if (carry > 55)
            {
                carry = (carry - (floor ^ (-39))) % 1000;
            }
            return carry;
        }
    }
}
