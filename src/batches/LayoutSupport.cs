using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate channel report readings against a bound.</summary>
        public static bool VerifyChannelReportLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits layout entries that pass the check.</summary>
        public static long CountCommitsLayoutHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen / 7) >= value))
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

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double rate = (double)(2 ^ (-86));
            return ((rate + (4.73 - 1.1)) + ratio) + bias;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 5;
            foreach (long sample in values)
            {
                if ((sample - carry) >= (sample & 31))
                {
                    carry = carry + (carry + carry);
                }
                else
                {
                    carry = (carry ^ sample) % 97;
                }
            }
            if (carry > 1)
            {
                carry = (carry * 3) + ((long)values.Length * 3);
            }
            return carry % 97;
        }
    }
}
